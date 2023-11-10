using CostTrackerDomain.Shared;
using CostTrackerApplication.Abstractions;
using CostTrackerDomain.ValueObjects;
using CostTrackerDomain.Abstractions.Data;
using CostTrackerDomain.Abstractions.Repositories;
using CostTrackerDomain.Aggregates;

namespace CostTrackerApplication.FinancialEvents.Commands.CreateFinancialEvent;

internal sealed class CreateFinancialEventCommandHandler : ICommandHandler<CreateFinancialEventCommand>
{
    private readonly IFinancialEventRepository _eventRepository;
    private readonly ICurrencyRepository _currencyRepository;
    private readonly ILabelRepository _labelRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateFinancialEventCommandHandler(
        IFinancialEventRepository eventRepository,
        ICurrencyRepository currencyRepository,
        ILabelRepository labelRepository,
        IUnitOfWork unitOfWork)
    {
        _eventRepository = eventRepository;
        _currencyRepository = currencyRepository;
        _labelRepository = labelRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task<Result> Handle(CreateFinancialEventCommand request, CancellationToken cancellationToken)
    {        
        var label = _labelRepository.GetById(request.labelId);
        var currency = _currencyRepository.GetById(request.CurrencyId);

        if (currency == null)
        {
            return Result.Failure(new Error(
                "Error.CurrencyNotFound",
                $"A currency with the ID: {request.CurrencyId} does not exist."));
        }

        if (label == null)
        {
            return Result.Failure(new Error(
                "Error.LabelNotFound",
                $"A Label with the ID: {request.labelId} does not exist."));
        }

        var note = EventNote.Create(request.noteValue);
        var amount = Amount.Create(request.AmountValue, request.CurrencyId);

        var financialEvent = FinancialEvent.Create(
            Guid.NewGuid(),
            note.Value,
            amount.Value,
            request.date,
            request.labelId);

        _eventRepository.Add(financialEvent.Value);

        await _unitOfWork.SaveChangesAsync();

        return Result.Success();
    }
}
