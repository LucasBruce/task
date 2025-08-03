using TaskApi.Core.Domain.Entities;

namespace TaskApi.Core.Application.DTOs.Requests
{
    public record class CreatedUserRequest
    (
        string Name,
        string CorporateEmail,
        string Job,
        List<Duty>? Duties
    )
    {
        public void Deconstruct(out string name, out string corporateEmail, out string job, out List<Duty>? duties)
        {
            name = Name;
            corporateEmail = CorporateEmail;
            job = Job;
            duties = Duties;
        }
    }
}