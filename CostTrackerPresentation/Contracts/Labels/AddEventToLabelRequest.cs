using CostTrackerDomain.Entities;
using CostTrackerDomain.ValueObjects;

namespace CostTrackerPresentation.Contracts.Labels;

public record AddEventToLabelRequest(
        Guid LabelId,
        double Amount,
        string Currency,
        DateTime Date,
        EventNote Note);


