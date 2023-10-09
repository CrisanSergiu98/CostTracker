using CostTrackerDomain.Abstractions.Data;

namespace CostTrackerPersistence;

internal sealed class UnitOfWork: IUnitOfWork
{
    private readonly ApplicationDBContext _dbContext;
    public UnitOfWork(ApplicationDBContext dbContext)
    {
        _dbContext = dbContext;
    }
    public Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return _dbContext.SaveChangesAsync(cancellationToken);
    }
}
