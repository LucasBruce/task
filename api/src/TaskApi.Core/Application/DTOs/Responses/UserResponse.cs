using TaskApi.Core.Domain.Entities;

namespace TaskApi.Core.Application.DTOs.Responses
{
    public class UserResponse
    {
        public Guid Id { get; set; }
        public bool IsCreated { get; set; } = false;
        public string Name { get; set; } = "";
        public string CorporateEmail { get; set; } = "";
        public string Job { get; set; } = "";
        public List<Duty>? Duties { get; set; } = new List<Duty>();
    }
}