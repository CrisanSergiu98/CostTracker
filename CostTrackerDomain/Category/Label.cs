using CostTrackerDomain.Primitives;

namespace CostTrackerDomain.Category;

public sealed class Label: Entity
{
    private Label(
        Guid id,
        string name,
        string description,
        Category category
        ):base(id)
    {
        Name = name;
        Description = description;
        Category = category;
    }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public Category Category { get; private set; }
    public Label CreateLabel(
        Guid id,
        string name,
        string description,
        Category category
        )
    {
        Label label = new Label( 
            id, 
            name, 
            description, 
            category );
        return label;
    }
}
