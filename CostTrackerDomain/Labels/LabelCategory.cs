using CostTrackerDomain.Shared;

namespace CostTrackerDomain.Labels;

public sealed class LabelCategory : Category
{
    public LabelCategory(Guid id, string name, Guid userId) : base(id, name)
    {
        UserId = userId;
    }

    public Guid UserId { get; set; }
}
