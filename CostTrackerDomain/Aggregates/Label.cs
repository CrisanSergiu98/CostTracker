using CostTrackerDomain.Entities;
using CostTrackerDomain.Primitives;
using CostTrackerDomain.Shared;
using CostTrackerDomain.ValueObjects;

namespace CostTrackerDomain.Aggregates;

public sealed class Label : AggregateRoot
{
    private readonly HashSet<FinancialEvent> _financialEvents = new();
    private Label(
        Guid Id,
        LabelName name,
        LabelDescription description,
        Money targetAmount,
        Guid UserId
        ) : base(Id)
    {
        Name = name;
        Description = description;
        TargetAmount = targetAmount;

    }

    public LabelName Name { get; private set; }
    public LabelDescription Description { get; private set; }
    public Money TargetAmount { get; private set; }
    public Guid UserId { get; private set; }

    public static Result<Label> CreateLabel(
        LabelName name,
        LabelDescription description,
        Money targetAmount,
        Guid userId
        )
    {
        Label label = new Label(
            Guid.NewGuid(),
            name,
            description,
            targetAmount,
            userId
            );
        return label;
    }
    public Result<Label> CreateFinancialEvent(
        Money amount,
        DateTime date,
        EventNote note)
    {
        FinancialEvent financialEvent = new FinancialEvent(
            Guid.NewGuid(),            
            amount,
            date,
            note);
        _financialEvents.Add(financialEvent);

        return Result.Success(this);
    }
}

