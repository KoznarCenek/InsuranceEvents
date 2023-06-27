using Insurance.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Insurance.Application.Interfaces;

namespace Insurance.Persistence.Extension;
public static class AddPersistenceExtension
{
    public static void AddPersistence(this IServiceCollection services, string dbPath)
    {
        services.AddDbContext<InsuranceDbContext>(options =>
            options.UseSqlite($"Data Source={dbPath}"));

        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddRepositories();
    }

    private static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IInsuredPersonRepository, InsuredPersonRepository>();
    }
}
