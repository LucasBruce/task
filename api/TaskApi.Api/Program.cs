using TaskApi.Core.Application.Interfaces;
using TaskApi.Core.Application.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ITaskService, TaskService>();

builder.Services.AddScoped<IUserService, UserService>();


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddControllers(); // Configura suporte a controllers

var app = builder.Build();

app.MapControllers();

app.UseHttpsRedirection();
