namespace CostTrackerApplication.Abstractions.Services;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}
