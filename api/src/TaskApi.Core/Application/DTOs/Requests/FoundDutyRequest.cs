namespace TaskApi.Core.Application.DTOs.Requests
{
    public record class FoundDutyRequest
    {
        public Guid Id { get; init; } = Guid.Empty;
        public string Title { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
    }
}
