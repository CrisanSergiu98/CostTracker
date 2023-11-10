using CostTrackerApplication.Abstractions;

namespace CostTrackerApplication.Users.Commands;

public sealed record RegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password): ICommand;

