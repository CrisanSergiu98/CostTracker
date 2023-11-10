namespace CostTrackerApplication.Abstractions.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(Guid userId, string fisrtName, string lastName);
}
