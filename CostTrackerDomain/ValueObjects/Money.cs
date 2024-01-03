using CostTrackerDomain.Primitives;
using CostTrackerDomain.Shared;

namespace CostTrackerDomain.ValueObjects;

public sealed class Money : ValueObject
{
    private Money(double amount, Currency currency)
    {
        Amount = amount;
        Currency = currency;
    }
    public double Amount { get; set; }
    public Currency Currency { get; set; }

    public static Result<Money> Create(double amount, string currencyValue)
    {
        
        if(amount == 0)
        {
            return Result.Failure<Money>(new Error(
                "Money.AmountIsZero",
                "The amount cannot be zero"));
        }

        if (amount < 0)
        {
            return Result.Failure<Money>(new Error(
                "Money.AmountIsNegative",
                "The amount cannot a negative number"));
        }

        Currency currency;

        Enum.TryParse(currencyValue, true, out currency);
        

        return new Money(amount, currency);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Amount;
        yield return Currency;
    }
}
