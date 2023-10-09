using CostTrackerDomain.Primitives;
using CostTrackerDomain.Shared;

namespace CostTrackerDomain.ValueObjects;

public sealed class EventNote : ValueObject
{
    public const int MaxLength = 150;
    private EventNote(string value)
    {
        Value = value;
    }
    public string Value { get; set; }

    public static Result<EventNote> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return Result.Failure<EventNote>(new Error(
                "Error.Note.Empty",
                "Note is empty"));
        }

        if (value.Length > MaxLength)
        {
            return Result.Failure<EventNote>(new Error(
                "Error.Note.MaxLengthExceeded",
                $"Note has more than {MaxLength} characters"));
        }

        return new EventNote(value);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}
