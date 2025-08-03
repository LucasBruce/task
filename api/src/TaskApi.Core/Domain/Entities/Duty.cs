namespace TaskApi.Core.Domain.Entities
{
    public readonly record struct Status
    (
            Boolean Pending,
            Boolean InProgress,
            Boolean Completed
    );

    public record class Duty
    (
         Guid Id,
         string Title,
         string Description,
         DateTime DueDate,
         Status Status,
         User User
    )
    {
        public void Deconstruct(out Guid id, out string title, out string description, out User user)
        {
            id = Id;
            title = Title;
            description = Description;
            user = User;
        }
        public void Deconstruct(out Guid id, out string title, out string description, out DateTime dueDate, out Status status, out User user)
        {
            id = Id;
            title = Title;
            description = Description;
            dueDate = DueDate;
            status = Status;
            user = User;
        }
    }
}
