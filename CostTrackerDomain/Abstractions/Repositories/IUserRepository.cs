using CostTrackerDomain.Abstractions.Data;
using CostTrackerDomain.Aggregates;
using CostTrackerDomain.ValueObjects;

namespace CostTrackerDomain.Abstractions.Repositories;

public interface IUserRepository : IRepository<User>
{
    Task<User?> GetUserByEmail(string email, CancellationToken cancellationToken = default);
    Task Add(User user, CancellationToken cancellationToken = default);
}
