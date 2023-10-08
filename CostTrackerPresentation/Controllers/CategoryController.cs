using CostTrackerApplciation.Categories.Commands.CreateCategory;
using CostTrackerDomain.Amounts;
using CostTrackerPresentation.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CostTrackerPresentation.Controllers;
[Route("api/category")]
public sealed class CategoryController : ApiController
{
    public CategoryController(ISender sender) 
        : base(sender)
    {

    }

    [HttpPost]
    public async Task<IActionResult> CreateCategory()
    {
        throw new NotImplementedException();
    }
}
