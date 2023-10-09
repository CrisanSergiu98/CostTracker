using CostTrackerDomain.Abstractions.Data;
using CostTrackerDomain.Labels;

namespace CostTrackerDomain.Repositories;

public interface ILabelRepository: IRepository<Label>
{
    Task<Label?> GetById(Guid id, CancellationToken cancellationToken = default);
    Task<Label?> GetAll(int userId);
    Task<Label?> GetAllWithEvents(int userId);
    void Remove(Label label);
    void Add(Label label);
}
