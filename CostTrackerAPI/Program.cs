using CostTrackerApplication;
using CostTrackerInfrastructure;
using CostTrackerPersistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddPersistence();

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
