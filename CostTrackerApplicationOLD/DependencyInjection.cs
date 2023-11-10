using Microsoft.Extensions.DependencyInjection;

namespace CostTrackerApplication;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {              

        return services;
    }
}
