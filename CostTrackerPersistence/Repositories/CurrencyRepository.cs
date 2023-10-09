using CostTrackerDomain.Currencies;
using CostTrackerDomain.Repositories;
using CostTrackerDomain.ValueObjects;

namespace CostTrackerPersistence.Repositories;

internal sealed class CurrencyRepository : ICurrencyRepository
{
    private readonly ApplicationDBContext _dbContext;

    public CurrencyRepository(ApplicationDBContext context)
    {
        _dbContext = context;
    }

    public void Add(Currency currency)
    {
        throw new NotImplementedException();
    }

    public Task<Currency?> GetAll(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Currency?> GetById(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Currency?> GetByName(CurrencyName name, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void Remove(Currency currency)
    {
        throw new NotImplementedException();
    }
}
