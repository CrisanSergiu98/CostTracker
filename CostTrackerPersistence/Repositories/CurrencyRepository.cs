using CostTrackerDomain.Currencies;
using CostTrackerDomain.Repositories;
using CostTrackerDomain.ValueObjects;

namespace CostTrackerPersistence.Repositories;

internal sealed class CurrencyRepository : ICurrencyRepository
{
    private readonly ApplicationDBContext _dbContext;
    private readonly List<Currency> _currencies;

    public void Add(Currency currency)
    {
        _currencies.Add(currency);
    }

    public Task<Currency?> GetAll(CancellationToken cancellationToken = default)
    {
        return Task.FromResult<_currencies>;
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
