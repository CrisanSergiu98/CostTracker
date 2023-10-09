using CostTrackerDomain.Primitives;

namespace CostTrackerDomain.Abstractions.Data;

public interface IRepository<in T>
    where T : AggregateRoot
{
}
