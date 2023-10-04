using CostTrackerDomain.Primitives;

namespace CostTrackerDomain.User;

public sealed class User: Entity
{
    private User(
        Guid id,
        string username,
        string passwordHash
        ):base(id)
    {
        Username = username;
        PasswordHash = passwordHash;
    }
    public string Username { get; private set; }
    public string PasswordHash { get; private set; }
    public User CreateUser(
        Guid id, 
        string username, 
        string passwordHash)
    {
        User user = new User(
            id,
            username,
            passwordHash);
        return user;
    }
}
