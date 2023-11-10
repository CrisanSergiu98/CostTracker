using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;
using CostTrackerDomain.Abstractions.Data;

namespace CostTrackerApplication;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        //services.AddSingleton(IApplicationDBContext)
        
        return services;
    }
}
