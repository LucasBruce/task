using TaskApi.Core.Domain.Entities;

namespace TaskApi.Core.Application.DTOs.Responses
{
    public class FoundDutyResponse
    {
        public Guid Id { get; set; }
        public bool IsCreated { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DueDate { get; set; }
        public Status Status { get; set; } = new Status();
        public UserResponse UserResponse { get; set; } = new UserResponse();
    }
}