using CostTrackerDomain.Amount;

namespace CostTrackerDomain.Category;

public class CategoryAmount: Amount.Amount
{
    public CategoryAmount(Guid id, double value, Currency currency):base(id, value, currency)
    {
        
    }
}
