
using TaskApi.Core.Domain.Entities;

namespace TaskApi.Core.Application.DTOs.Requests
{
    public class CreatedUserRequest
    {
        public string Name { get; set; } = string.Empty;
        public string CorporateEmail { get; set; } = string.Empty;
        public string Job { get; set; } = string.Empty;
        public List<Duty>? Duties { get; set; }
    }
}