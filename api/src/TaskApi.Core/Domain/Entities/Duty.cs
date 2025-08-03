namespace TaskApi.Core.Domain.Entities
{
    public readonly record struct Status
    (
            Boolean Pending,
            Boolean InProgress,
            Boolean Completed
    );

    public record class Duty
    {
        public Guid Id { get; init; } = Guid.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DueDate { get; set; } = DateTime.MinValue;
        public Status Status { get; set; } = new Status(false, false, false);
        public User User { get; set; } = new User
        {
            Id = Guid.Empty,
            Name = string.Empty,
            CorporateEmail = string.Empty,
            Job = string.Empty,
            Duties = new List<Duty>()
        };
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