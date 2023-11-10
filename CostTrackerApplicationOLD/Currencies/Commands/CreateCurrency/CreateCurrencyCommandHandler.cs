using CostTrackerApplication.Abstractions;
using CostTrackerDomain.Abstractions.Data;
using CostTrackerDomain.Abstractions.Repositories;
using CostTrackerDomain.Aggregates;
using CostTrackerDomain.Shared;
using CostTrackerDomain.ValueObjects;

namespace CostTrackerApplication.Currencies.Commands.CreateCurrency;

internal sealed class CreateCurrencyCommandHandler : ICommandHandler<CreateCurrencyCommand>
{
    private readonly ICurrencyRepository _currencyRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateCurrencyCommandHandler(
        ICurrencyRepository currencyRepository,
        IUnitOfWork unitOfWork)
    {
        _currencyRepository = currencyRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task<Result> Handle(CreateCurrencyCommand request, CancellationToken cancellationToken)
    {
        var resultedCurrency = _currencyRepository.GetByName(request.CurrencyName);

        if (resultedCurrency != null) 
        {
            return Result.Failure(new Error(
                "Error.CateogryNameAlreadyExists",
                $"A Currency with the name {request.CurrencyName} already exists."));
        }

        resultedCurrency = _currencyRepository.GetBySymbol(request.CurrencySymbol);

        if (resultedCurrency != null)
        {
            return Result.Failure(new Error(
                "Error.CateogrySymbolAlreadyExists",
                $"A Currency with the symbol {request.CurrencySymbol} already exists."));
        }

        var currencyName = CurrencyName.Create(request.CurrencyName);
        var currencySymbol = CurrencySymbol.Create(request.CurrencySymbol);       

        var currency = Currency.Create(
            Guid.NewGuid(),
            currencyName.Value,
            currencySymbol.Value);

        //Assign ValueInDollars

        _currencyRepository.Add(currency.Value);

        await _unitOfWork.SaveChangesAsync();

        return Result.Success();
    }
}
