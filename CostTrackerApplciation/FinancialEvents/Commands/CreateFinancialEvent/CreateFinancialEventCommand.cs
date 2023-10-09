using CostTrackerDomain.ValueObjects;
using CostTrackerApplciation.Abstractions;
using CostTrackerDomain.Shared;

namespace CostTrackerApplciation.FinancialEvents.Commands.CreateFinancialEvent;

public sealed record CreateFinancialEventCommand(
    string noteValue,
    double AmountValue,
    Guid CurrencyId,
    DateTime date,
    Guid labelId
    ) : ICommand;

