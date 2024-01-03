using CostTrackerApplication.Abstractions;
using CostTrackerDomain.Abstractions.Repositories;
using CostTrackerDomain.Shared;
using CostTrackerDomain.ValueObjects;

namespace CostTrackerApplication.Labels.Commands.UpdateLabelInfo;

internal sealed class UpdateLabelInfoCommandHandler : ICommandHandler<UpdateLabelInfoCommand>
{
    private readonly ILabelRepository _labelRepository;
    public UpdateLabelInfoCommandHandler(
        ILabelRepository labelRepository)
    {
        _labelRepository = labelRepository;
    }

    public async Task<Result> Handle(UpdateLabelInfoCommand request, CancellationToken cancellationToken)
    {
        var label = _labelRepository.GetById(request.labelId).Result;

        var labelName = LabelName.Create(request.Name);
        var labelDescription = LabelDescription.Create(request.Description);
        var targetAmount = Money.Create(request.TargetAmmount,request.TargetCurrency);

        // assign the new value objects   

        //persist
        _labelRepository.UpdateLabel(label);

        return Result.Success();
    }
}
