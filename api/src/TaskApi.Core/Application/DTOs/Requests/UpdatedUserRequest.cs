using TaskApi.Core.Domain.Entities;

namespace TaskApi.Core.Application.DTOs.Requests
{
    public record class UpdatedUserRequest
    (
        Guid Id,
        string? Name,
        string? CorporateEmail,
        string? Job,
        List<Duty>? Duties
    )
    {
        public void Deconstruct(out Guid id, out string? name, out string? corporateEmail)
        {
            id = Id;
            name = Name;
            corporateEmail = CorporateEmail;
  
        }
    }
}