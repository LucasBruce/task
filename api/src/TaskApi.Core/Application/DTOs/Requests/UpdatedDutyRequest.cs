using TaskApi.Core.Domain.Entities;

namespace TaskApi.Core.Application.DTOs.Requests
{
    public record class UpdatedDutyRequest : FoundDutyBase
    {
        public DateTime? DueDate { get; set; }
        public Status? Status { get; set; }
        public User? User { get; set; }
        public void Deconstruct(out Guid id, out string title, out string description, out DateTime? dueDate, out Status? status, out User? user)
        {
            base.Deconstruct(out id, out title, out description);
            dueDate = DueDate;
            status = Status;
            user = User;
        }
    }
}