using CostTrackerApplication.Abstractions;

namespace CostTrackerApplication.Labels.Commands.UpdateLabelInfo;

public record UpdateLabelInfoCommand(
    Guid labelId,
    string Name,
    string Description,
    double TargetAmmount,
    string TargetCurrency
    ):ICommand;
