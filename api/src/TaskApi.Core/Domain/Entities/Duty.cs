namespace TaskApi.Core.Domain.Entities
{
    public class Duty
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DueDate { get; set; } = DateTime.Now;
        public Status Status { get; set; } = new Status();
        public User User { get; set; } = new User();
    }
}
