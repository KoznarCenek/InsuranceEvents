using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;

namespace Insurance.Application.ExtensionConfig;
public static class AddApplicationExtension
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
    }
}
