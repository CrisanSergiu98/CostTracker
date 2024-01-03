using CostTrackerApplication.Abstractions;

namespace CostTrackerApplication.Users.Queries.LoginUser;

public sealed record LoginQuery(
    string Email,
    string Password) : IQuery;

