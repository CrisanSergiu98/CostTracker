using CostTrackerDomain.Primitives;

namespace CostTrackerDomain.Shared;

public class Currency : Entity
{
    public static readonly Currency Ron = new Currency(
        Guid.NewGuid(),
        "Romanina Leu",
        "RON"
        );

    public static readonly Currency Dollar = new Currency(
        Guid.NewGuid(),
        "American Dollar",
        "$"
        );

    private Currency(
        Guid id,
        string name,
        string symbol
        ) : base(id)
    {
        Name = name;
        Symbol = symbol;
    }
    public string Name { get; private set; }
    public string Symbol { get; private set; }
    public double ValueInDollars { get; private set; }

    public static Currency CreateCurrency(
        string name,
        string symbol)
    {
        Currency currency = new Currency(Guid.NewGuid(), name, symbol);
        //Assign ValueInDollars
        return currency;
    }
}
