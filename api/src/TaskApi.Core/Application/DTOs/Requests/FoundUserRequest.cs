namespace TaskApi.Core.Application.DTOs.Requests
{
    public record class FoundUserRequest
    (
        Guid Id,
        string Name,
        string CorporateEmail
    );
}