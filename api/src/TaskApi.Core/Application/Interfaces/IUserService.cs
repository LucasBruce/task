using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.DTOs.Responses;

namespace TaskApi.Core.Application.Interfaces
{
    public interface IUserService
    {
        Task<List<UserResponse>> GetAllUsers();
        Task<UserResponse> CreateUser(CreatedUserRequest createdUserRequest);
        Task<UserResponse> UpdateUser(UpdatedUserRequest updatedUserRequest);
        Task<FoundUserResponse> FindUser(FoundUserRequest foundUserRequest);
        Task<bool> DeleteUser(FoundUserRequest foundUserRequest);
    }
}