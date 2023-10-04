using CostTrackerDomain.Primitives;

namespace CostTrackerDomain.Amount;

public class Currency: Entity
{
    private Currency(
        Guid id,
        string name,
        string symbol
        ):base(id)
    {
        Name = name;
        Symbol = symbol;
    }
    public string Name { get; private set; }
    public string Symbol { get; private set; }
    public double ValueInDollars { get; private set; }

    public Currency CreateCurrency(
        Guid id,
        string name,
        string symbol)
    {
        Currency currency = new Currency(id,name,symbol);
        //Assign ValueInDollars
        return currency;
    }
}
