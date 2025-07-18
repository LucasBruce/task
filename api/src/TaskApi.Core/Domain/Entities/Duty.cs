namespace TaskApi.Core.Domain.Entities
{
    public class Duty
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public DateTime DueDate { get; set; } = DateTime.Now;
        public Status Status { get; set; } = new Status();
    }
}
