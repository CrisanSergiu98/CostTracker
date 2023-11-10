using CostTrackerApplication.Abstractions;
using CostTrackerApplication.Abstractions.Authentication;
using CostTrackerDomain.Abstractions.Repositories;
using CostTrackerDomain.Aggregates;
using CostTrackerDomain.Shared;

namespace CostTrackerApplication.Users.Queries;

internal sealed class LoginQueryHandler : IQueryHandler<LoginQuery>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;
    public LoginQueryHandler(
        IJwtTokenGenerator jwtTokenGenerator,
        IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }
    public async Task<Result> Handle(LoginQuery request, CancellationToken cancellationToken)
    {
        // 1. Validate the user exists
        var user = _userRepository.GetUserByEmail(request.Email).Result;

        if (user == null)
        {
            throw new Exception($"A user with the email: {request.Email} does not exists.");
        }

        // 2. Validate the password
        if (user.Password != request.Password)
        {
            throw new Exception($"Password is incorrect");
        }

        // 3. Create JWT token
        var token = _jwtTokenGenerator.GenerateToken(user.Id, user.FirstName, user.LastName);        

        return Result.Success(token);
    }
}
