using CostTrackerDomain.Amounts;
using MediatR;

namespace CostTrackerApplciation.FinancialEvents.Commands.CreateFinancialEvent;

public sealed record CreateFinancialEventCommand(
    string Note,
    Amount Amount,
    DateTime Date,
    CostTrackerDomain.Categories.Label Label
    ) : IRequest;

