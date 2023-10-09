using CostTrackerDomain.Primitives;
using CostTrackerDomain.Shared;

namespace CostTrackerDomain.ValueObjects;

public sealed class LabelName: ValueObject
{
    public const int MaxLength = 50;
    private LabelName(string value)
    {
        Value = value;
    }
    public string Value { get; set; }

    public static Result<LabelName> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return Result.Failure<LabelName>(new Error(
                "Error.LabelName.Empty",
                "LabelName is empty"));
        }

        if (value.Length > MaxLength)
        {
            return Result.Failure<LabelName>(new Error(
                "Error.LabelName.MaxLengthExceeded",
                $"LabelName has more than {MaxLength} characters"));
        }

        return new LabelName(value);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}
