using CostTrackerApplication.Abstractions.Services;

namespace CostTrackerInfrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
