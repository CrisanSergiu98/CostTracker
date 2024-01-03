using CostTrackerApplication.Abstractions;
using CostTrackerDomain.Abstractions.Repositories;
using CostTrackerDomain.Shared;

namespace CostTrackerApplication.Labels.Queries.GetAllLabels;

internal sealed class GetAllLabelsQueryHandler : IQueryHandler<GetAllLabelsQuery>
{
    private readonly ILabelRepository _labelRepository;
    public GetAllLabelsQueryHandler(ILabelRepository labelRepository)
    {
        _labelRepository = labelRepository;
    }
    public async Task<Result> Handle(GetAllLabelsQuery request, CancellationToken cancellationToken)
    {
        var result = _labelRepository.GetAll(request.UserId);

        if(result.Result is null)
        {
            return Result.Failure(new Error(
                "Error.NoLabelsFound", 
                $"No label was found for the user: {request.UserId}."));
        }

        return Result.Success(result.Result);
    }
}
