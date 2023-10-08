using MediatR;

namespace CostTrackerApplciation.Labels.Commands.CreateLabel;

internal sealed class CreateLabelCommandHandler : IRequestHandler<CreateLabelCommand>
{
    public Task Handle(CreateLabelCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();

        //
    }
}
