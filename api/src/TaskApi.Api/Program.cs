using TaskApi.Core.Application.Interfaces;
using TaskApi.Core.Application.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddControllers();

// TODO: Implement ComposeApplication or replace with actual service registrations
// builder.Services.ComposeApplication(builder.Configuration);

var app = builder.Build();

app.MapControllers();

app.UseHttpsRedirection();

app.Run();
