using CostTrackerDomain.Primitives;

namespace CostTrackerDomain.Shared;

public abstract class Category : Entity
{
    public Category(Guid id, string name) : base(id)
    {
        Name = name;
    }

    public string Name { get; set; }    
}
