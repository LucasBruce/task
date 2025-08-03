namespace TaskApi.Core.Application.DTOs.Requests
{
    public record class FoundDutyRequest
    (
        Guid Id,
        string Title,
        string Description
    );
}