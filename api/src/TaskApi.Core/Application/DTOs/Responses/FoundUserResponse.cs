namespace TaskApi.Core.Application.DTOs.Responses
{
    public record class FoundUserResponse
    (
        Guid Id,
        string Name,
        string CorporateEmail,
        string Job,
        List<DutyResponse> Duties
    )
    {
        public void Deconstruct(out Guid id, out string name, out string corporateEmail)
        {
            id = Id;
            name = Name;
            corporateEmail = CorporateEmail;
        }
    }
}