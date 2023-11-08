namespace CostTrackerApplciation.Services.Authentication;

public interface IAuthService
{
    AuthResult Login(
        string email,
        string password);
    AuthResult Register(
        string fistName,
        string lastName,
        string email,
        string password);
}
