namespace TaskApi.Domain.Entities
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public DateTime DueDate { get; set; } = DateTime.Now;
        public Status Status { get; set; } = new Status();
    }
}
