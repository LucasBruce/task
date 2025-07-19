using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.DTOs.Responses;

namespace TaskApi.Core.Application.Interfaces
{
    public interface IUserService
    {
        Task<List<FoundUserResponse>> GetAllUsers();
        Task<FoundUserResponse> CreateUser(CreatedUserRequest createdUserRequest);
        Task<FoundUserResponse> UpdateUser(UpdatedUserRequest updatedUserRequest);
        Task<FoundUserResponse> FindUser(FoundUserRequest foundUserRequest);
        Task<bool> DeleteUser(FoundUserRequest foundUserRequest);
    }
}