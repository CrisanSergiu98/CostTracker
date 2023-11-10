using CostTrackerApplication.Abstractions;

namespace CostTrackerApplication.FinancialEvents.Commands.CreateFinancialEvent;

public sealed record CreateFinancialEventCommand(
    string noteValue,
    double AmountValue,
    Guid CurrencyId,
    DateTime date,
    Guid labelId
    ) : ICommand;

