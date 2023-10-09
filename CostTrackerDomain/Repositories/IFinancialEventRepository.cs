using CostTrackerDomain.Abstractions.Data;
using CostTrackerDomain.FinancialEvents;

namespace CostTrackerDomain.Repositories;

public interface IFinancialEventRepository:IRepository<FinancialEvent>
{
    Task<FinancialEvent?> GetAllByLabel(Guid userId, Guid labelId, CancellationToken cancellationToket = default);
    void Remove(FinancialEvent financialEvent);
    void Add(FinancialEvent financialEvent);
}
