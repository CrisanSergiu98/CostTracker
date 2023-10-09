using CostTrackerDomain.Primitives;
using CostTrackerDomain.Shared;

namespace CostTrackerDomain.ValueObjects;

public sealed class LabelDescription:ValueObject
{
    public const int MaxLength = 150;
    private LabelDescription(string value)
    {
        Value = value;
    }
    public string Value { get; set; }

    public static Result<LabelDescription> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return Result.Failure<LabelDescription>(new Error(
                "Error.LabelDescription.Empty",
                "LabelDescription is empty"));
        }

        if (value.Length > MaxLength)
        {
            return Result.Failure<LabelDescription>(new Error(
                "Error.LabelDescription.MaxLengthExceeded",
                $"LabelDescription has more than {MaxLength} characters"));
        }

        return new LabelDescription(value);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}
