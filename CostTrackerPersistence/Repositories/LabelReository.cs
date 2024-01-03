using CostTrackerDomain.Abstractions.Repositories;
using CostTrackerDomain.Aggregates;

namespace CostTrackerPersistence.Repositories;

internal sealed class LabelReository : ILabelRepository
{
    private List<Label> _labels = new();
    private readonly ApplicationDBContext _dbContext;

    public LabelReository(ApplicationDBContext context)
    {
        _dbContext = context;
    }

    public void Add(Label label)
    {
        _dbContext.Add(label);
        _dbContext.SaveChanges();
    }

    public Task<Label?> GetAll(Guid userId, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(_labels.SingleOrDefault(u => u.UserId == userId));
    }

    public Task<Label?> GetById(Guid id, CancellationToken cancellationToken = default)
    {
        
        return Task.FromResult(_labels.SingleOrDefault(u => u.Id == id));
        
    } 

    public void Remove(Label label)
    {
        _labels.Remove(label);
    }

    public void UpdateLabel(Label label, CancellationToken cancellationToken = default)
    {
        var old = _labels.SingleOrDefault(u => u.Id == label.Id);
        _labels[_labels.IndexOf(old)] = label;
    }
}
