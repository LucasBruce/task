using TaskApi.Core.Extensions;
using TaskApi.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddControllers();

builder.Services.AddCore();

builder.Services.AddInfrastructure();

var app = builder.Build();

app.MapControllers();

app.UseHttpsRedirection();

app.Run();