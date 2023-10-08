using CostTrackerDomain.Shared;

namespace CostTrackerDomain.Errors;

public static class DomainErrors
{
    public static class Label
    {
        public static readonly Error InavlidOperation = new Error(
            "Label.InvalidOperation",
            "The operation you tried to perform is invalid");
    }
}
