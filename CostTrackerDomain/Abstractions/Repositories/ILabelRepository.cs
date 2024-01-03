using CostTrackerDomain.Abstractions.Data;
using CostTrackerDomain.Aggregates;

namespace CostTrackerDomain.Abstractions.Repositories;

public interface ILabelRepository : IRepository<Label>
{
    Task<Label?> GetById(Guid id, CancellationToken cancellationToken = default);
    Task<Label?> GetAll(Guid userId, CancellationToken cancellationToken = default);
    void UpdateLabel(Label label, CancellationToken cancellationToken = default);
    void Remove(Label label);
    void Add(Label label);
}
