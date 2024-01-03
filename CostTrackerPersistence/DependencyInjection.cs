using CostTrackerDomain.Abstractions.Repositories;
using CostTrackerPersistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CostTrackerPersistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(
        this IServiceCollection services)
    {
        //services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(configuration.GetConnectionString("Default")););
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<ILabelRepository, LabelReository>();
        services.AddDbContext<ApplicationDBContext>();

        return services;
    }
}
