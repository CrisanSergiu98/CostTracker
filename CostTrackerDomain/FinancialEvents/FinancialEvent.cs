using CostTrackerDomain.Primitives;
using CostTrackerDomain.ValueObjects;

namespace CostTrackerDomain.FinancialEvents;

public class FinancialEvent: AggregateRoot
{
    private FinancialEvent(
        Guid id,
        string note,
        Amount amount,
        DateTime date,
        Guid labelId
        ):base(id)
    {
        Note = note;
        Amount = amount;
        Date = date;
        LabelId = labelId;
    }
    public string Note { get; private set; }
    public Amount Amount { get; private set; }
    public DateTime Date { get; private set; }
    public Guid LabelId{ get; private set; }
    public static FinancialEvent CreateEvent(
        Guid id,
        string note,
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
