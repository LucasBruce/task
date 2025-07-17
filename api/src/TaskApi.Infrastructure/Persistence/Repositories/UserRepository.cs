using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApi.Core.Application.DTOs.Responses;
using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.Interfaces;

namespace TaskApi.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task<UserResponse> CreateUser(CreatedUserRequest createdUserRequest)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUser(FoundUserRequest foundUserRequest)
        {
            throw new NotImplementedException();
        }

        public Task<UserResponse> FindUser(FoundUserRequest foundUserRequest)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserResponse>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<UserResponse> UpdateUser(UpdatedUserRequest updatedUserRequest)
        {
            throw new NotImplementedException();
        }
    }
}