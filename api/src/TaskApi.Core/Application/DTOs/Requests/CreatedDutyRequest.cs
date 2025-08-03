
namespace TaskApi.Core.Application.DTOs.Requests
{
    public record struct CreateDutyStatus
    (
            Boolean Pending,
            Boolean InProgress,
            Boolean Completed
    );

    public record class CreatedDutyRequest
    (
        string Title,
        string Description,
        DateTime DueDate,
        CreateDutyStatus Status,
        CreatedUserRequest User
    );
}