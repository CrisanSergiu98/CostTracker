using CostTrackerDomain.Primitives;
using CostTrackerDomain.Shared;
using CostTrackerDomain.ValueObjects;

namespace CostTrackerDomain.Aggregates;

public class Currency : AggregateRoot
{
    private Currency(
        Guid id,
        CurrencyName name,
        CurrencySymbol symbol
        ) : base(id)
    {
        Name = name;
        Symbol = symbol;
    }
    public CurrencyName Name { get; private set; }
    public CurrencySymbol Symbol { get; private set; }
    public double ValueInDollars { get; private set; }

    public static Result<Currency> Create(
        Guid id,
        CurrencyName name,
        CurrencySymbol symbol)
    {
        Currency currency = new Currency(
            id,
            name,
            symbol);

        //Assign ValueInDollars

        return currency;
    }
}
