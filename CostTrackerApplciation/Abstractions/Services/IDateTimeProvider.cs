﻿namespace CostTrackerApplciation.Abstractions.Services;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}
