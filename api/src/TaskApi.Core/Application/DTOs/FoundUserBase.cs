namespace TaskApi.Core.Application.DTOs.Requests
{
    public record class FoundUserBase
    {
        public Guid Id { get; set; } = Guid.Empty;
        public string Name { get; set; } = string.Empty;
        public string CorporateEmail { get; set; } = string.Empty;
        public void Deconstruct(out Guid id, out string name, out string corporateEmail)
        {
            id = Id;
            name = Name;
            corporateEmail = CorporateEmail;
        }
        public void Deconstruct(out string name, out string corporateEmail)
        {
            name = Name;
            corporateEmail = CorporateEmail;
        }     
    }
}