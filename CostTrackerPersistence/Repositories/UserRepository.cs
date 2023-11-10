using CostTrackerDomain.Abstractions.Repositories;
using CostTrackerDomain.Aggregates;

namespace CostTrackerPersistence.Repositories;

public sealed class UserRepository : IUserRepository
{
    private static List<User> _users = new();

    public Task Add(User user, CancellationToken cancellationToken = default)
    {
        _users.Add(user);
        return Task.CompletedTask;
    }

    public Task<User?> GetUserByEmail(string email, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(_users.SingleOrDefault(u => u.Email == email));
    }
}
