using CostTrackerApplication.Abstractions;
using CostTrackerApplication.Abstractions.Authentication;
using CostTrackerDomain.Abstractions.Repositories;
using CostTrackerDomain.Aggregates;
using CostTrackerDomain.Shared;

namespace CostTrackerApplication.Users.Commands.RegisterUser;

internal sealed class RegisterCommandHandler
    : ICommandHandler<RegisterCommand>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;
    public RegisterCommandHandler(IJwtTokenGenerator jwtTokenGenerator,
        IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public async Task<Result> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        //Check if the user already exists
        if (_userRepository.GetUserByEmail(request.Email).Result is not null)
        {
            return Result.Failure(new Error(
                "Error.EmailInUse",
                $"Email already in use."));
        }

        //Create user (generate unique ID)
        var user = User.Create(
            Guid.NewGuid(),
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password);

        //Persist the user

        await _userRepository.Add(user.Value);

        //Create JWT token
        var token = _jwtTokenGenerator.GenerateToken(user.Value.Id, user.Value.FirstName, user.Value.LastName);

        //Return Token
        return Result.Success(token);
    }
}
