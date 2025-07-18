using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.DTOs.Responses;
using TaskApi.Core.Application.Interfaces;

namespace TaskApi.Core.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<UserResponse> CreateUser(CreatedUserRequest createdUserRequest)
        {
            var userResponse = _userRepository.CreateUser(createdUserRequest);

            return userResponse;
        }

        public Task<bool> DeleteUser(FoundUserRequest foundUserRequest)
        {
            var isDeleted = _userRepository.DeleteUser(foundUserRequest);

            return isDeleted;
        }

        public Task<UserResponse> FindUser(FoundUserRequest foundUserRequest)
        {
            var userResponse = _userRepository.FindUser(foundUserRequest);

            return userResponse;
        }

        public Task<List<UserResponse>> GetAllUsers()
        {
            var users = _userRepository.GetAllUsers();

            return users;
        }

        public Task<UserResponse> UpdateUser(UpdatedUserRequest updatedUserRequest)
        {
            var userResponse = _userRepository.UpdateUser(updatedUserRequest);

            return userResponse;
        }
    }
}