namespace TaskApi.Core.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string CorporateEmail { get; set; } = "";
        public string Job { get; set; } = "";
        public List<Task> Tasks { get; set; } = new List<Task>();
    }
}
