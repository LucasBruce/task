using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Domain.Entities;

namespace TaskApi.Core.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserResponse>> GetAllUsers();
        Task<UserResponse> CreateUser(CreatedUserRequest createdUserRequest);
        Task<UserResponse> UpdateUser(UpdatedUserRequest updatedUserRequest);
        Task<UserResponse> FindUser(FoundUserRequest foundUserRequest);
        Task<bool> DeleteUser(FoundUserRequest foundUserRequest);
    }
}