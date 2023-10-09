using CostTrackerDomain.Abstractions.Data;
using CostTrackerDomain.Currencies;
using CostTrackerDomain.ValueObjects;

namespace CostTrackerDomain.Repositories;

public interface ICurrencyRepository: IRepository<Currency>
{
    Task<Currency?> GetAll(CancellationToken cancellationToken=default);
    Task<Currency?> GetById(Guid id, CancellationToken cancellationToken = default);
    Task<Currency?> GetByName(string name, CancellationToken cancellationToken = default);
    Task<Currency?> GetBySymbol(string name, CancellationToken cancellationToken = default);
    void Remove(Currency currency);
    void Add(Currency currency);
}
