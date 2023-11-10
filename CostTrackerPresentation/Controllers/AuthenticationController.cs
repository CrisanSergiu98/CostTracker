using CostTrackerApplication.Users.Commands;
using CostTrackerApplication.Users.Queries;
using CostTrackerPresentation.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CostTrackerPresentation;

[Route("api/auth")]
public class AuthenticationController : ApiController
{    
    public AuthenticationController(ISender sender) 
        : base(sender)
    {
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var command = new RegisterCommand(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password);

        var result = await Sender.Send(command);

        return result.IsSuccess ? Ok(result) : BadRequest(result.Error);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var query = new LoginQuery(
            request.Email,
            request.Password);

        var result = await Sender.Send(query);

        return result.IsSuccess ? Ok(result) : BadRequest(result.Error);
    }
}
