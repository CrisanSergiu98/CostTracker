using CostTrackerDomain.Primitives;
using CostTrackerDomain.Shared;

namespace CostTrackerDomain.ValueObjects;

public sealed class Amount : ValueObject
{
    public Amount(double value, Currency currency)
    {
        Value = value;
        Currency = currency;
    }
    public double Value { get; private set; }
    public Currency Currency { get; private set; }
    public override IEnumerable<object> GetAtomicValues()
    {
        yield return new NotImplementedException();
    }
    
}
