namespace CostTrackerContracts.Authentication;

public record LoginRequest(
    string Email,
    string Password);