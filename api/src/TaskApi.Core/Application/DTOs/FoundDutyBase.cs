namespace TaskApi.Core.Application.DTOs.Requests
{
    public record class FoundDutyBase
    {
        public Guid Id { get; init; } = Guid.Empty;
        public string Title { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public void Deconstruct(out Guid id, out string title, out string description)
        {
            id = Id;
            title = Title;
            description = Description;
        }
        public void Deconstruct(out string title, out string description)
        {
            title = Title;
            description = Description;
        } 
    }
}
