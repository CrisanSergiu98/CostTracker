using CostTrackerDomain.Abstractions.Repositories;
using CostTrackerDomain.Aggregates;

namespace CostTrackerPersistence.Repositories;

internal sealed class FinancialEventRepository : IFinancialEventRepository
{
    //private readonly ApplicationDBContext _dbContext;
    public FinancialEventRepository(/*ApplicationDBContext context*/)
    {
        //_dbContext = context;
    }
    public void Add(FinancialEvent label)
    {
        throw new NotImplementedException();
    }

    public Task<FinancialEvent?> GetAllByLabel(Guid userId, Guid labelId, CancellationToken cancellationToket = default)
    {
        throw new NotImplementedException();
    }

    public void Remove(FinancialEvent label)
    {
        throw new NotImplementedException();
    }
}
