namespace TaskApi.Core.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string CorporateEmail { get; set; } = string.Empty;
        public string Job { get; set; } = string.Empty;
        public List<Duty> Duties { get; set; } = new List<Duty>();
    }
}
