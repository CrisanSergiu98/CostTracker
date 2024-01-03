using CostTrackerApplication.Abstractions;

namespace CostTrackerApplication.Labels.Commands.CreateLabel;

public sealed record CreateLabelCommand(
    string Name,
    string Description,
    double Amount,
    string Currency,
    Guid UserId
    ) : ICommand;

