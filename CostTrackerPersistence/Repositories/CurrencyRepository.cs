using CostTrackerDomain.Abstractions.Repositories;
using CostTrackerDomain.Aggregates;

namespace CostTrackerPersistence.Repositories;

internal sealed class CurrencyRepository : ICurrencyRepository
{
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

    public Task<Currency?> GetByName(string name, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Currency?> GetBySymbol(string name, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void Remove(Currency currency)
    {
        throw new NotImplementedException();
    }
}
