﻿using CostTrackerApplciation.Abstractions;

namespace CostTrackerApplciation.Labels.Commands.CreateLabel;

public sealed record CreateLabelCommand(
    string Name,
    string Description,
    double AmountValue,
    Guid CurrencyId,
    string CategoryValue,
    Guid UserId
    ) : ICommand;

