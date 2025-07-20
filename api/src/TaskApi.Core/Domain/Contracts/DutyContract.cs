namespace TaskApi.Core.Domain.Entities
{
    public interface IDutyContract<U, S>
    {
        Guid Id { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        DateTime DueDate { get; set; }
        S Status { get; set; }
        U User { get; set; }
    }
}
