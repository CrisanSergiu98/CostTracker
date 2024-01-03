using CostTrackerDomain.Entities;
using CostTrackerApplication.Abstractions;
using CostTrackerDomain.ValueObjects;

namespace CostTrackerApplication.Labels.Commands.AddEvent;

public sealed record AddEventCommand(
    Guid LabelId,
    double Amount,
    string Currency,
    DateTime Date,
    EventNote Note
    ) :ICommand;

