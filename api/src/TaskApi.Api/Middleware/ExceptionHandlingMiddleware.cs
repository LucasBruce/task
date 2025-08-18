using System.Net;
using System.Text.Json;
using TaskApi.Core.Domain.Exception;

namespace TaskApi.Api.Middleware;

public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        HttpStatusCode statusCode;
        string message;

        if (exception is UserNotFoundException) {
            statusCode = HttpStatusCode.NotFound;
            message = exception.Message;
        } else {
            statusCode = HttpStatusCode.InternalServerError;
            message = "Ocorreu um erro interno no servidor.";
        }

        var result = JsonSerializer.Serialize(new
        {
            error = message,
            code = (int)statusCode
        });

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)statusCode;
        return context.Response.WriteAsync(result);
    }
}
