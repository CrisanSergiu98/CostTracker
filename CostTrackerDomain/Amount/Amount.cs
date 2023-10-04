using CostTrackerDomain.Primitives;

namespace CostTrackerDomain.Amount;

public class Amount : Entity
{
    protected Amount(
        Guid Id,
        double value,
        Currency currency
        ) : base(Id)
    {
        Value = value;
        Currency = currency;
    }
    public double Value { get; private set; }
    public Currency Currency { get; private set; }
    public Amount CreateAmmount(Guid id, double value, Currency currency)
    {
        Amount ammount = new Amount(
            id,
            value,
            currency);
        return ammount;
    }
}
