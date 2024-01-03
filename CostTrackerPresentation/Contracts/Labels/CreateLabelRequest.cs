namespace CostTrackerPresentation.Contracts.Labels;

public record CreateLabelRequest(
    string Name,
    string Description,
    double Amount,
    string Currency,
    Guid UserId
    );