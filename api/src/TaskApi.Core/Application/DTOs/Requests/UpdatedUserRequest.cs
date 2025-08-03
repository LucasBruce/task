using TaskApi.Core.Domain.Entities;

namespace TaskApi.Core.Application.DTOs.Requests
{
    public record class UpdatedUserRequest : FoundUserBase
    {
        public string? Job { get; init; }
        public List<Duty>? Duties { get; init; }
        public void Deconstruct(out Guid id, out string name, out string corporateEmail, out string? job, out List<Duty>? duties)
        {
            base.Deconstruct(out id, out name, out corporateEmail);
            job = Job;
            duties = Duties;
        }
    }
}