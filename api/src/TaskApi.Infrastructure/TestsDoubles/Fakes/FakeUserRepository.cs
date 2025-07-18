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
        private readonly List<UserResponse> _users = UserResponseStubs.GetAll();

        public Task<UserResponse> CreateUser(CreatedUserRequest createdUserRequest)
        {
            var userResponse = new UserResponse
            {
                IsCreated = true,
                Name = createdUserRequest.Name,
                CorporateEmail = createdUserRequest.CorporateEmail,
                Job = createdUserRequest.Job,
                Duties = createdUserRequest.Duties ?? []
            };

            _users.Add(userResponse);

            return Task.FromResult(userResponse);
        }

        public Task<bool> DeleteUser(FoundUserRequest foundUserRequest)
        {
            var user = FindUser(foundUserRequest).Result;

            _users.Remove(user);

            return Task.FromResult(true);
        }

        public Task<UserResponse> FindUser(FoundUserRequest foundUserRequest)
        {
            var user = _users.FirstOrDefault(element => element.Id == foundUserRequest.Id);
            if (user == null)
            {
                throw new NotImplementedException();
            }

            return Task.FromResult(user);
        }

        public Task<List<UserResponse>> GetAllUsers()
        {
            return Task.FromResult(_users);
        }

        public Task<UserResponse> UpdateUser(UpdatedUserRequest updatedUserRequest)
        {
            var user = _users.FirstOrDefault(element => element.Id == updatedUserRequest.Id);
            if (user == null)
            {
                throw new NotImplementedException();
            }

            user.Name = updatedUserRequest.Name ?? user.Name;
            user.CorporateEmail = updatedUserRequest.CorporateEmail ?? user.CorporateEmail;
            user.Job = updatedUserRequest.Job ?? user.Job;
            user.Duties = updatedUserRequest.Duties ?? user.Duties;

            return Task.FromResult(user);
        }

    }
}