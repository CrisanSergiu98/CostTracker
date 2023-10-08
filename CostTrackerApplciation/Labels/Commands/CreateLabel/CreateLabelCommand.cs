using MediatR;

namespace CostTrackerApplciation.Labels.Commands.CreateLabel;

public sealed record CreateLabelCommand(
    string Name,
    string Description,
    CostTrackerDomain.Categories.Category Category
    ) : IRequest;

