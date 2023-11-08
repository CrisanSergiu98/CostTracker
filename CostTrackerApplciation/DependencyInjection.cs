using CostTrackerApplciation.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace CostTrackerApplciation;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();

        return services;
    }
}
