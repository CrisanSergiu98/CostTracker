﻿using CostTrackerDomain.Shared;
using MediatR;

namespace CostTrackerApplciation.Abstractions;

public interface ICommandHandler<TCommand>: IRequestHandler<TCommand, Result>
    where TCommand : ICommand
{
}

public interface ICommandHandler<TCommand, TResponse>
    : IRequestHandler<TCommand, Result<TResponse>>
    where TCommand : ICommand<TResponse>
{
}
