using TaskApi.Api.Middleware;
using TaskApi.Core.Extensions;
using TaskApi.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", policy =>
    {
        policy
            .AllowAnyOrigin()      // ou .WithOrigins("http://localhost:5173")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddControllers();

builder.Services.AddCore();

builder.Services.AddInfrastructure();

var app = builder.Build();

app.UseCors("CorsPolicy");

app.UseMiddleware<ExceptionHandlingMiddleware>();

// 2️⃣ Aplicar a política
app.UseCors("AllowAngularApp");

app.MapControllers();

app.UseHttpsRedirection();

app.Run();