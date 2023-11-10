using CostTrackerApplication.Abstractions;
using CostTrackerDomain.Abstractions.Data;
using CostTrackerDomain.Abstractions.Repositories;
using CostTrackerDomain.Aggregates;
using CostTrackerDomain.Shared;
using CostTrackerDomain.ValueObjects;

namespace CostTrackerApplication.Labels.Commands.CreateLabel;

internal sealed class CreateLabelCommandHandler : ICommandHandler<CreateLabelCommand>
{
    private readonly ILabelRepository _labelRepository;
    private readonly IUnitOfWork _unitOfWork;
    public CreateLabelCommandHandler(ILabelRepository labelRepository, IUnitOfWork unitOfWork)
    {
        _labelRepository = labelRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task<Result> Handle(CreateLabelCommand request, CancellationToken cancellationToken)
    {
        var labelName = LabelName.Create(request.Name);
        var labelDescription = LabelDescription.Create(request.Description);
        var labelCategory = LabelCategory.Create(request.Name);
        var targetAmount = Amount.Create(request.AmountValue,request.CurrencyId);

        var label = Label.Create(
            Guid.NewGuid(),
            labelName.Value,
            labelDescription.Value,
            targetAmount.Value,
            labelCategory.Value,            
            request.UserId
            );

        _labelRepository.Add(label.Value);

        await _unitOfWork.SaveChangesAsync();

        return Result.Success();       
    }
}
