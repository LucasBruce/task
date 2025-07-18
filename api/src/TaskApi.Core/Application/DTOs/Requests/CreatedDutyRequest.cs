using TaskApi.Core.Domain.Entities;

namespace TaskApi.Core.Application.DTOs.Requests
{
    public class CreatedDutyRequest
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public DateTime DueDate { get; set; } = DateTime.Now;
        public Status Status { get; set; } = new Status();
    }
}