using CostTrackerDomain.Shared;
using MediatR;

namespace CostTrackerApplication.Abstractions;

public interface IQuery : IRequest<Result>
{
}

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{

}
