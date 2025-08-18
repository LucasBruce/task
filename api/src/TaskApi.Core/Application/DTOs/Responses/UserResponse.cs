namespace TaskApi.Core.Application.DTOs.Responses
{
    public record class UserResponse
    (
        Guid Id,
        string Name,
        string Job,
        List<DutyResponse> Duties
    )
    {
        public void Deconstruct(out Guid id, out string name, out string job)
        {
            id = Id;
            name = Name;
            job = Job;
        }
    }
}