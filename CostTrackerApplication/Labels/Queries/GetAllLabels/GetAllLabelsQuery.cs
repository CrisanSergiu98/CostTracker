using CostTrackerApplication.Abstractions;
using CostTrackerDomain.Aggregates;

namespace CostTrackerApplication.Labels.Queries.GetAllLabels;

public record GetAllLabelsQuery(
    Guid UserId):IQuery;
