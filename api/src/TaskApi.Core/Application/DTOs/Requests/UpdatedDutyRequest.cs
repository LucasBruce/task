using TaskApi.Core.Domain.Entities;

namespace TaskApi.Core.Application.DTOs.Requests
{
    public record class UpdatedDutyRequest
    (
        Guid Id,
        string Title,
        string Description,
        DateTime? DueDate,
        Status? Status,
        User? User
    );
}