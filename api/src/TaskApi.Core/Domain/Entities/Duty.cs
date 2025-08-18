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
        public Guid Id { get; set; } = Guid.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DueDate { get; set; } = DateTime.MinValue;
        public Status Status { get; set; } = new Status(false, false, false);
        public Owner Owner { get; set; } = new Owner
        {
            Id = Guid.Empty,
            Name = string.Empty,
            CorporateEmail = string.Empty,
            Job = string.Empty,
        };
        public void Deconstruct(out Guid id, out string title, out string description, out Owner owner)
        {
            id = Id;
            title = Title;
            description = Description;
            owner = Owner;
        }
        public void Deconstruct(out Guid id, out string title, out string description, out DateTime dueDate, out Status status, out Owner owner)
        {
            id = Id;
            title = Title;
            description = Description;
            dueDate = DueDate;
            status = Status;
            owner = Owner;
        }
    }
}