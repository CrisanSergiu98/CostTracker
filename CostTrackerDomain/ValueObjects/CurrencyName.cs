using CostTrackerDomain.Primitives;
using CostTrackerDomain.Shared;

namespace CostTrackerDomain.ValueObjects;

public sealed class CurrencyName: ValueObject
{
    public const int MaxLength = 50;
    private CurrencyName(string value)
    {
        Value = value;
    }
    public string Value { get; set; }

    public static Result<CurrencyName> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return Result.Failure<CurrencyName>(new Error(
                "Error.CurrencyName.Empty",
                "CurrencyName is empty"));
        }

        if (value.Length > MaxLength)
        {
            return Result.Failure<CurrencyName>(new Error(
                "Error.CurrencyName.MaxLengthExceeded",
                $"CurrencyName has more than {MaxLength} characters"));
        }

        return new CurrencyName(value);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}
