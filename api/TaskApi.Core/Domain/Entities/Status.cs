namespace TaskApi.Core.Domain.Entities
{
    public class Status
    {
        public Guid Id { get; set; }
        public Boolean Pending { get; set; }
        public Boolean InProgress { get; set; }
        public Boolean Completed { get; set; }
    }
}
