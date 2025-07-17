using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.Interfaces;
using TaskApi.Core.Application.DTOs.Responses;
using TaskApi.Infrastructure.TestsDoubles.Stubs;

namespace TaskApi.Infrastructure.TestsDoubles.Fakes
{
    public class FakeUserRepository : IUserRepository
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
              return Task.FromResult(UserResponseStubs.GetAll());
        }

        public Task<UserResponse> UpdateUser(UpdatedUserRequest updatedUserRequest)
        {
            throw new NotImplementedException();
        }
    }
}