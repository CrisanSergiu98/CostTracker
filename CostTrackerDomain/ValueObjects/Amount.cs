using CostTrackerDomain.Primitives;
using CostTrackerDomain.Shared;

namespace CostTrackerDomain.ValueObjects;

public sealed class Amount : ValueObject
{
    private Amount(double value, Guid currencyId)
    {
        Value = value;
        CurrencyId = currencyId;
    }
    public double Value { get; private set; }
    public Guid CurrencyId { get; private set; }
    public static Result<Amount> Create(double value, Guid currencyId)
    {
        return new Amount(value, currencyId);
    }
    public override IEnumerable<object> GetAtomicValues()
    {
        yield return new NotImplementedException();
    }    
}
