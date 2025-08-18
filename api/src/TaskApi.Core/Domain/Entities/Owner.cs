namespace TaskApi.Core.Domain.Entities
{
      public readonly record struct Owner
    (
        Guid Id,
        string Name,
        string CorporateEmail,
        string Job
    );
}