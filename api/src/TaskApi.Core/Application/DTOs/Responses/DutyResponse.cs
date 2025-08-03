namespace TaskApi.Core.Application.DTOs.Responses
{
    public readonly record struct Owner
    (
        Guid Id,
        string Name,
        string Job
    );

    public record class DutyResponse
    (
        Guid Id,
        string Title,
        string Description,
        Owner Owner
    );
}