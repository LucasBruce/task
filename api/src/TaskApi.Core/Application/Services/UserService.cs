using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.Interfaces;

namespace TaskApi.Core.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public Task<UserResponse> CreateUser(CreatedUserRequest createdUserRequest)
        {
            var userResponse = this.userRepository.CreateUser(createdUserRequest);

            return userResponse;
        }

        public Task<bool> DeleteUser(FoundUserRequest foundUserRequest)
        {
            var isDeleted = this.userRepository.DeleteUser(foundUserRequest);

            return isDeleted;
        }

        public Task<UserResponse> FindUser(FoundUserRequest foundUserRequest)
        {
            var userResponse = this.userRepository.FindUser(foundUserRequest);

            return userResponse;
        }

        public Task<IEnumerable<UserResponse>> GetAllUsers()
        {
            var users = this.userRepository.GetAllUsers();

            return users;
        }

        public Task<UserResponse> UpdateUser(UpdatedUserRequest updatedUserRequest)
        {
            var userResponse = this.userRepository.UpdateUser(updatedUserRequest);

            return userResponse;
        }
    }
}