using CostTrackerApplication.Abstractions;
using CostTrackerDomain.Abstractions.Repositories;
using CostTrackerDomain.Shared;
using CostTrackerDomain.ValueObjects;

namespace CostTrackerApplication.Labels.Commands.AddEvent;

internal sealed class AddEventCommandHandler : ICommandHandler<AddEventCommand>
{
    private readonly ILabelRepository _labelRepository;
    public AddEventCommandHandler(ILabelRepository labelRepository)
    {
        _labelRepository = labelRepository;
    }
    public async Task<Result> Handle(AddEventCommand request, CancellationToken cancellationToken)
    {
        // Validate the label
        var label = _labelRepository.GetById(request.LabelId).Result;

        if(label is null)
        {
            return Result.Failure(new Error
            (
                "Error.LabelNotFound",
                $"The label with the ID: {request.LabelId} was not found."
            ));
        }

        var amount = Money.Create(request.Amount,request.Currency);

        // Add the Event to the label

        label.CreateFinancialEvent(
            amount.Value,
            request.Date,
            request.Note
            );

        // Persist the label

        _labelRepository.UpdateLabel(label);

        // Return a result
        return Result.Success();
    }
}
