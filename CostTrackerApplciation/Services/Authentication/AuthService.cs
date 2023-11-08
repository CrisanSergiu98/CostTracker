using CostTrackerApplciation.Abstractions.Authentication;

namespace CostTrackerApplciation.Services.Authentication;

public class AuthService : IAuthService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    public AuthService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }
    AuthResult IAuthService.Register(
        string firstName, 
        string lastName, 
        string email, 
        string password)
    {
        //Check if the user already exists

        //Create user (generate unique ID)

        Guid userId = Guid.NewGuid();

        //Create JWT token

        var token = _jwtTokenGenerator.GenerateToken(userId,firstName,lastName);

        return new AuthResult(
            Guid.NewGuid(), 
            firstName, 
            lastName, 
            email, 
            token); 
    }

    AuthResult IAuthService.Login(
        string email, 
        string password)
    {
        return new AuthResult(
            Guid.NewGuid(),
            "fistName",
            "lastName",
            email,
            "token");
    }
}
