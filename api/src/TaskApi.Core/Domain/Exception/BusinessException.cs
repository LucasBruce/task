namespace TaskApi.Core.Domain.Exception
{
    public class BusinessException : System.Exception
    {
        public Guid Id { get; }
        public BusinessException(string message) : base(message)
        {
            Id = Guid.NewGuid();
        }
    } 
}