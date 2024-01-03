using CostTrackerApplication.Abstractions;
using CostTrackerDomain.Shared;

namespace CostTrackerApplication.Labels.Commands.UpdateEvent;

internal sealed class UpdateEventCommandHandler : ICommandHandler<UpdateEventCommand>
{
    public Task<Result> Handle(UpdateEventCommand request, CancellationToken cancellationToken)
    {
        //Get the Label that the Event is part of

        //Modify the Label

        //Persist

        throw new NotImplementedException();
    }
}
