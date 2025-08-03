namespace TaskApi.Core.Application.DTOs.Requests
{
    public record class FoundUserRequest
    {
        public Guid Id { get; init; } = Guid.Empty;
        public string Name { get; set; } = string.Empty;
        public string CorporateEmail { get; set; } = string.Empty;
    }
}