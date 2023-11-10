using CostTrackerApplication.Abstractions.Authentication;
using CostTrackerApplication.Abstractions.Services;
using CostTrackerInfrastructure.Authentication;
using CostTrackerInfrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace CostTrackerInfrastructure;

public static class DependencyInjection
{    
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        ConfigurationManager configuartion)
    {        
        services.Configure<JwtSettings>(configuartion.GetSection(JwtSettings.SecctionName));

        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        return services;
    }
}
