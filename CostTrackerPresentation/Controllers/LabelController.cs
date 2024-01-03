using CostTrackerApplication.Labels.Commands.AddEvent;
using CostTrackerApplication.Labels.Commands.CreateLabel;
using CostTrackerApplication.Labels.Queries.GetAllLabels;
using CostTrackerPresentation.Abstractions;
using CostTrackerPresentation.Contracts.Labels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CostTrackerPresentation.Controllers;

[Route("api/labels")]
public class LabelController : ApiController
{
    public LabelController(ISender sender) : base(sender)
    {
    }
    [HttpPost("add-event")]
    public async Task<IActionResult> AddEventToLabel(AddEventToLabelRequest request)
    {
        var command = new AddEventCommand(
            request.LabelId,
            request.Amount,
            request.Currency,
            request.Date,
            request.Note);

        var result = await Sender.Send(command);

        return result.IsSuccess ? Ok(result) : BadRequest(result.Error);
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateLabel(CreateLabelRequest request)
    {
        var command = new CreateLabelCommand(
            request.Name,
            request.Description,
            request.Amount,
            request.Currency,
            request.UserId
            );

        var result = await Sender.Send(command);

        return result.IsSuccess ? Ok(result) : BadRequest(result.Error);
    }

    [HttpGet("get-all")]
    public async Task<IActionResult> GetAll(GetAllLabelsRequest request)
    {
        var query = new GetAllLabelsQuery(
            request.UserId);

        var result = await Sender.Send(query);

        return result.IsSuccess ? Ok(result) : BadRequest(result.Error);
    }
}
