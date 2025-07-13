namespace TaskApi.Core.Application.DTOs.Requests
{
    public class CreatedUserRequest
    {
        public string Name { get; set; } = "";
        public string CorporateEmail { get; set; } = "";
        public string Job { get; set; } = "";
        public List<Task> Tasks { get; set; } = new List<Task>();
    }
}