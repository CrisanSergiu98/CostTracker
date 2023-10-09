using CostTrackerDomain.Primitives;
using CostTrackerDomain.Shared;

namespace CostTrackerDomain.ValueObjects;

public sealed class LabelCategory : ValueObject
{
    public const int MaxLength = 50;
    private LabelCategory(string value)
    {
        Value = value;
    }
    public string Value { get; private set; }
    public static Result<LabelCategory> Create(string value)
    {
        if(string.IsNullOrWhiteSpace(value))
        {
            return Result.Failure<LabelCategory>(new Error(
                "Error.LabelCategory.Empty",
                "LabelCategory is empty"));
        }

        if(value.Length > MaxLength)
        {
            return Result.Failure<LabelCategory>(new Error(
                "Error.LabelCategory.MaxLengthExceeded",
                $"LabelCategory has more than {MaxLength} characters"));
        }

        return new LabelCategory(value);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}
