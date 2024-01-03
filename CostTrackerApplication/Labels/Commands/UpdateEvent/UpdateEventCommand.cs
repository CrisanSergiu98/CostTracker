using CostTrackerApplication.Abstractions;

namespace CostTrackerApplication.Labels.Commands.UpdateEvent;

public record UpdateEventCommand(
    Guid LabelId,
    Guid EventId,
    double AmountInDollars,
    string Note,
    DateTime Date
    ): ICommand;