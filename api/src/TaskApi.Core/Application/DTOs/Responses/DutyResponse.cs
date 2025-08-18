using TaskApi.Core.Domain.Entities;

namespace TaskApi.Core.Application.DTOs.Responses
{
    public record class DutyResponse
    (
        Guid Id,
        string Title,
        string Description,
        Owner Owner
    );
}