using CostTrackerApplication.Abstractions;
using CostTrackerDomain.Abstractions.Repositories;
using CostTrackerDomain.Shared;

namespace CostTrackerApplication.Labels.Commands.DeleteLabel;

internal sealed class DeleteLabelCommandHandler : ICommandHandler<DeleteLabelCommand>
{
    private readonly ILabelRepository _labelRepository;
    public DeleteLabelCommandHandler(ILabelRepository labelRepository)
    {
        _labelRepository = labelRepository;
    }
    public async Task<Result> Handle(DeleteLabelCommand request, CancellationToken cancellationToken)
    {
        //Validate the Id by:
        //Get Label from repository

        var label = _labelRepository.GetById(request.LabelId);

        //Call the unit of work to persist the changes

        //Return Success
        return Result.Success();
    }
}
