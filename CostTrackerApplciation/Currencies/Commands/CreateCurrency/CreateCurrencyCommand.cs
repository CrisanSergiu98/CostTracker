using CostTrackerApplciation.Abstractions;

namespace CostTrackerApplciation.Currencies.Commands.CreateCurrency;

public sealed record CreateCurrencyCommand(
    string CurrencyName,
    string CurrencySymbol
    ):ICommand;

