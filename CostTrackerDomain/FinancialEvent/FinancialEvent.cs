using CostTrackerDomain.Amount;
using CostTrackerDomain.Primitives;
using System.Reflection.Emit;

namespace CostTrackerDomain.FinancialEvent;

public class FinancialEvent: Entity
{
    private FinancialEvent(
        Guid id,
        string note,
        Amount.Amount amount,
        DateTime date,
        Label label
        ):base(id)
    {
        Note = note;
        Amount = amount;
        Date = date;
        Label = label;
    }
    public string Note { get; private set; }
    public Amount.Amount Amount { get; private set; }
    public DateTime Date { get; private set; }
    public Label Label { get; private set; }
    public FinancialEvent CreateEvent(
        Guid id,
        string note,
        Amount.Amount amount,
        DateTime date,
        Label label) 
    { 
        FinancialEvent financialEvent = new FinancialEvent(
            id,
            note,
            amount,
            date,
            label);
        return financialEvent;

    }
}
