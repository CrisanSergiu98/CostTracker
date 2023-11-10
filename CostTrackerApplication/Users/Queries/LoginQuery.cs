using CostTrackerApplication.Abstractions;

namespace CostTrackerApplication.Users.Queries;

public sealed record LoginQuery(
    string Email,
    string Password) :IQuery;

