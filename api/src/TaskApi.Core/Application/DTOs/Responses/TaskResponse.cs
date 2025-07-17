using TaskApi.Core.Domain.Entities;

namespace TaskApi.Core.Application.DTOs.Responses
{
    public class TaskResponse
    {
        public bool IsCreated { get; set; } = false;
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public DateTime DueDate { get; set; } = DateTime.Now;
        public Status Status { get; set; } = new Status();
    }
}