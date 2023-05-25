using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Persistence.Extension;
public static class AddPersistenceExtension
{
    public static void AddPersistence(this IServiceCollection services, string dbPath)
    {
        services.AddDbContext<InsuranceDbContext>(options =>
            options.UseSqlite($"Data Source={dbPath}"));
    }
}
