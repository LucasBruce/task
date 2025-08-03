namespace TaskApi.Core.Domain.Entities
{
    public record class User
    {
        public Guid Id { get; init; } = Guid.Empty;
        public string Name { get; set; } = string.Empty;
        public string CorporateEmail { get; set; } = string.Empty;
        public string Job { get; set; } = string.Empty;
        public List<Duty> Duties { get; set; } = new List<Duty>();
        public void Deconstruct(out Guid id, out string name, out string job)
        {
            id = Id;
            name = Name;
            job = Job;
        }
        public void Deconstruct(out string name, out string corporateEmail, out string job, out List<Duty> duties)
        {
            name = Name;
            corporateEmail = CorporateEmail;
            job = Job;
            duties = Duties;
        }
        public void Deconstruct(out Guid id, out string name, out string corporateEmail, out string job, out List<Duty> duties)
        {
            id = Id;
            name = Name;
            corporateEmail = CorporateEmail;
            job = Job;
            duties = Duties;
        }
    }
}