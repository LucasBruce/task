using TaskApi.Core.Domain.Entities;

namespace TaskApi.Core.Application.DTOs.Requests
{
    public record class CreatedUserRequest : FoundUserBase
    {
        public string Job { get; set; } = string.Empty;
        public List<Duty>? Duties { get; set; } = new List<Duty>();
        public void Deconstruct(out string name, out string corporateEmail, out string job, out List<Duty>? duties)
        {
            base.Deconstruct(out name, out corporateEmail);
            job = Job;
            duties = Duties;
        }
    }
}