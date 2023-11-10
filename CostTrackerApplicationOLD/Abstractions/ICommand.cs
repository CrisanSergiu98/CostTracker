using CostTrackerDomain.Shared;
using MediatR;

namespace CostTrackerApplication.Abstractions;

public interface ICommand: IRequest<Result>
{
}

public interface ICommand<TResponse>: IRequest<Result<TResponse>>
{

}
