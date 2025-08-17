using TaskApi.Core.Domain.Entities;

namespace TaskApi.Core.Application.DTOs.Responses
{
    public record class FoundDutyResponse
    (
        Guid Id,
        string Title,
        string Description,
        DateTime DueDate,
        Status Status,
        Owner Owner
    );
}