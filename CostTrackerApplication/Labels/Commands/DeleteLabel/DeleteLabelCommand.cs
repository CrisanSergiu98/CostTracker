using CostTrackerApplication.Abstractions;

namespace CostTrackerApplication.Labels.Commands.DeleteLabel;

public sealed record DeleteLabelCommand(
    Guid LabelId
    ):ICommand;
