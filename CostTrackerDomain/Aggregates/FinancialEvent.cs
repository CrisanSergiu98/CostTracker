using CostTrackerDomain.Primitives;
using CostTrackerDomain.Shared;
using CostTrackerDomain.ValueObjects;

namespace CostTrackerDomain.Aggregates;

public sealed class FinancialEvent : AggregateRoot
{
    private FinancialEvent(
        Guid id,
        EventNote note,
        Amount amount,
        DateTime date,
        Guid labelId
        ) : base(id)
    {
        Note = note;
        Amount = amount;
        Date = date;
        LabelId = labelId;
    }
    public EventNote Note { get; private set; }
    public Amount Amount { get; private set; }
    public DateTime Date { get; private set; }
    public Guid LabelId { get; private set; }
    public static Result<FinancialEvent> Create(
        Guid id,
        EventNote note,
        Amount amount,
        DateTime date,
        Guid labelId)
    {
        FinancialEvent financialEvent = new FinancialEvent(
            id,
            note,
            amount,
            date,
            labelId);
        return financialEvent;

    }
}
