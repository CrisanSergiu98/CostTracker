using CostTrackerApplciation.Abstractions;
using CostTrackerApplciation.Category.Commands.CreateCategory;
using CostTrackerPresentation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(CostTrackerApplciation.AssemblyReference.Assembly);
});
//Configure Controller outside the project so we can define the controllers in the presentation layer
builder
    .Services
    .AddControllers()
    .AddApplicationPart(CostTrackerPresentation.AssemblyReference.Assembly);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
