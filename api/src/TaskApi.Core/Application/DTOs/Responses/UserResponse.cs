using TaskApi.Core.Domain.Entities;
using Task = System.Threading.Tasks.Task;

namespace TaskApi.Core.Application.DTOs.Requests
{
    public class UserResponse
    {
        public bool IsCreated { get; set; } = false;
        public string Name { get; set; } = "";
        public string CorporateEmail { get; set; } = "";
        public string Job { get; set; } = "";
        public List<Task> Tasks { get; set; } = new List<Task>();
    }
}