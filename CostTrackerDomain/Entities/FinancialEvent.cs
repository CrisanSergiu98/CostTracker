using CostTrackerDomain.Primitives;
using CostTrackerDomain.ValueObjects;

namespace CostTrackerDomain.Entities;

public sealed class FinancialEvent : Entity
{
    internal FinancialEvent(
        Guid id,        
        Money amount,
        DateTime date,
        EventNote note
        ) : base(id)
    {
        Note = note;
        Amount = amount;
        Date = date;
    }    
    public Money Amount { get; private set; }
    public DateTime Date { get; private set; }
    public EventNote Note { get; private set; }
}
