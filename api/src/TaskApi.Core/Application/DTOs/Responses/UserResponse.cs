
namespace TaskApi.Core.Application.DTOs.Responses
{
    public class UserResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Job { get; set; } = string.Empty;
        public List<DutyResponse> Duties { get; set; } = new List<DutyResponse>();
    }
}