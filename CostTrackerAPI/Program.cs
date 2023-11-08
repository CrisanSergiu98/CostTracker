using CostTrackerApplciation;
using CostTrackerApplciation.Services.Authentication;
using CostTrackerInfrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(CostTrackerApplciation.AssemblyReference.Assembly);
});
//Configure Controller outside the project so we can define the controllers in the presentation layer
builder
    .Services
    .AddControllers()
    .AddApplicationPart(CostTrackerPresentation.AssemblyReference.Assembly);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
