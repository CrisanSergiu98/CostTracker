using CostTrackerDomain.Primitives;
using CostTrackerDomain.Shared;

namespace CostTrackerDomain.ValueObjects;

public sealed class CurrencySymbol: ValueObject
{
    public const int MaxLength = 3;
    private CurrencySymbol(string value)
    {
        Value = value;
    }
    public string Value { get; set; }

    public static Result<CurrencySymbol> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return Result.Failure<CurrencySymbol>(new Error(
                "Error.CurrencySymbol.Empty",
                "CurrencySymbol is empty"));
        }

        if (value.Length > MaxLength)
        {
            return Result.Failure<CurrencySymbol>(new Error(
                "Error.CurrencySymbol.MaxLengthExceeded",
                $"CurrencySymbol has more than {MaxLength} characters"));
        }

        return new CurrencySymbol(value);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}
