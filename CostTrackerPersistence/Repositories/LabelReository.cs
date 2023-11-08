using CostTrackerDomain.Labels;
using CostTrackerDomain.Repositories;

namespace CostTrackerPersistence.Repositories;

internal sealed class LabelReository : ILabelRepository
{
    private readonly ApplicationDBContext _dbContext;

    public LabelReository(ApplicationDBContext context)
    {
        _dbContext = context;
    }

    public void Add(Label label)
    {
        throw new NotImplementedException();
    }

    public Task<Label?> GetAll(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<Label?> GetAllWithEvents(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<Label?> GetById(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void Remove(Label label)
    {
        throw new NotImplementedException();
    }
}
