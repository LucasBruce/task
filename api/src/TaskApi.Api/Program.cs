using TaskApi.Core.Application.Interfaces;
using TaskApi.Core.Extensions;
using TaskApi.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddControllers();

builder.Services.AddCore();

builder.Services.AddInfrastructure();

var app = builder.Build();

app.MapControllers();

app.UseHttpsRedirection();

app.Run();