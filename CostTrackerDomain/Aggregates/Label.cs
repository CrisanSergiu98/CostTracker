using CostTrackerDomain.Primitives;
using CostTrackerDomain.Shared;
using CostTrackerDomain.ValueObjects;

namespace CostTrackerDomain.Aggregates;

public sealed class Label : AggregateRoot
{
    private Label(
        Guid Id,
        LabelName name,
        LabelDescription description,
        Amount targetAmount,
        LabelCategory category,
        Guid UserId
        ) : base(Id)
    {
        Name = name;
        Description = description;
        TargetAmount = targetAmount;
        Category = category;

    }
    public LabelName Name { get; private set; }
    public LabelDescription Description { get; private set; }
    public Amount TargetAmount { get; private set; }
    public LabelCategory Category { get; set; }
    public Guid UserId { get; private set; }
    public static Result<Label> Create(
        Guid id,
        LabelName name,
        LabelDescription description,
        Amount targetAmount,
        LabelCategory category,
        Guid userId
        )
    {
        Label label = new Label(
            id,
            name,
            description,
            targetAmount,
            category,
            userId
            );
        return label;
    }
}

