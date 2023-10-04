using CostTrackerDomain.Amount;
using CostTrackerDomain.Primitives;

namespace CostTrackerDomain.Category;

public class Category: Entity
{
    private Category(
        Guid Id,
        string name,
        string description,
        Amount.Amount targetAmount,
        User.User user
        ):base(Id)
    {
        Name= name;
        Description= description;
        TargetAmmount= targetAmount;
        User= user;
    }
    public string Name {  get; private set; }
    public string Description { get; private set; }
    public Amount.Amount TargetAmmount { get; private set; }
    public User.User User { get; private set; }
    public Category CreateCategory(
        Guid id,
        string name,
        string description,
        Amount.Amount targetAmount,
        User.User user
        )
    {
        Category category = new Category(
            id,
            name,
            description,
            targetAmount,
            user
            );
        return category;
    }

}
