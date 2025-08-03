namespace TaskApi.Core.Domain.Entities
{
    public record class User
    (
         Guid Id = default,
         string Name = "",
         string CorporateEmail = "",
         string Job = "",
         List<Duty> Duties = null
    )
    {
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
