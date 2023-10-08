using CostTrackerDomain.Shared;
using MediatR;

namespace CostTrackerApplciation.Abstractions;

public interface ICommand: IRequest<Result>
{
}

public interface ICommand<TResponse>: IRequest<Result<TResponse>>
{

}
