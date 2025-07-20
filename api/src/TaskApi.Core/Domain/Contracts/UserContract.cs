namespace TaskApi.Core.Domain.Entities
{
    public interface IUserContract<U>
    {
         Guid Id { get; set; }
         string Name { get; set; }
         string CorporateEmail { get; set; }
         string Job { get; set; }
         List<U> Duties { get; set; }
    }
}
