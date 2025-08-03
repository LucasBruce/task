
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
        public CreatedUserRequest? User { get; set; }
        public void Deconstruct(out string title, out string description, out DateTime dueDate, out CreateDutyStatus status, out CreatedUserRequest? user)
        {
            base.Deconstruct(out title, out description);
            dueDate = DueDate;
            status = Status;
            user = User;
        }
    };
}