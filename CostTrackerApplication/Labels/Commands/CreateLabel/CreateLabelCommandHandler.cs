using CostTrackerApplication.Abstractions;
using CostTrackerDomain.Abstractions.Repositories;
using CostTrackerDomain.Aggregates;
using CostTrackerDomain.Shared;
using CostTrackerDomain.ValueObjects;

namespace CostTrackerApplication.Labels.Commands.CreateLabel;

internal sealed class CreateLabelCommandHandler : ICommandHandler<CreateLabelCommand>
{
    private readonly ILabelRepository _labelRepository;
    public CreateLabelCommandHandler(
        ILabelRepository labelRepository)
    {
        _labelRepository = labelRepository;
    }
    public async Task<Result> Handle(CreateLabelCommand request, CancellationToken cancellationToken)
    {
        var labelName = LabelName.Create(request.Name);
        var labelDescription = LabelDescription.Create(request.Description);
        var targetAmount = Money.Create(request.Amount, request.Currency);        

        var label = Label.CreateLabel(
            labelName.Value,
            labelDescription.Value,
            targetAmount.Value,          
            request.UserId
            );

        _labelRepository.Add(label.Value);

        return Result.Success();       
    }
}
