
using TaskApi.Core.Domain.Entities;

namespace TaskApi.Core.Application.DTOs.Requests
{
    public record struct CreateDutyStatus
    (
            Boolean Pending,
            Boolean InProgress,
            Boolean Completed
    );
    public record class CreatedDutyRequest : FoundDutyBase
    {
        public DateTime DueDate { get; set; }
        public CreateDutyStatus Status { get; set; }
        public Owner? Owner { get; set; }
        public void Deconstruct(out string title, out string? description, out DateTime dueDate, out CreateDutyStatus status, out Owner? owner)
        {
            base.Deconstruct(out title, out description);
            dueDate = DueDate;
            status = Status;
            owner = Owner;
        }
    };
}