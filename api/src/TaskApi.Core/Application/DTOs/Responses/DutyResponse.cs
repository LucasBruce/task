
namespace TaskApi.Core.Application.DTOs.Responses
{
    public record Owner
    (
        Guid Id,
        string Name,
        string Job
    );

    public class DutyResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Owner Owner { get; set; } = new Owner(
            Guid.Empty, 
            string.Empty, 
            string.Empty
        );
    }
}