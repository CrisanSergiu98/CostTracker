using CostTrackerDomain.Primitives;
using CostTrackerDomain.Shared;
using System.Runtime.InteropServices;

namespace CostTrackerDomain.Aggregates;

public sealed class User : AggregateRoot
{
    private User(
        Guid id,
        string firstName,
        string lastName,
        string email,
        string password
        ):base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }    
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }

    public static Result<User> Create(
        Guid id,
        string firstName,
        string lastName,
        string email,
        string password)
    {
        var user = new User(
            id,
            firstName,
            lastName,
            email,
            password);

        return Result.Success(user);
    }



}
