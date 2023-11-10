using CostTrackerApplication.Abstractions;

namespace CostTrackerApplication.Currencies.Commands.CreateCurrency;

public sealed record CreateCurrencyCommand(
    string CurrencyName,
    string CurrencySymbol
    ):ICommand;

