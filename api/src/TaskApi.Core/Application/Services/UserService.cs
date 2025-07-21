using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.DTOs.Responses;
using TaskApi.Core.Application.Interfaces;
using TaskApi.Core.Application.Mappings;
using TaskApi.Core.Domain.Entities;

namespace TaskApi.Core.Application.Services
{
    public class UserService : IUserService
    {
        // private readonly IUserRepository _userRepository;

        // public UserService(IUserRepository userRepository, AutoMapperUser autoMapperProfile)
        // {
        //     _userRepository = userRepository;
        //     _autoMapperProfile = autoMapperProfile;
        // }
        // {
        //     _userRepository = userRepository;
        // }

        // public Task<UserResponse> CreateUser(CreatedUserRequest createdUserRequest)
        // {
        //     var userResponse = _userRepository.CreateUser(createdUserRequest);

        //     return userResponse;
        // }

        // public Task<bool> DeleteUser(FoundUserRequest foundUserRequest)
        // {
        //     var isDeleted = _userRepository.DeleteUser(foundUserRequest);

        //     return isDeleted;
        // }

        // public Task<UserResponse> FindUser(FoundUserRequest foundUserRequest)
        // {
        //     var userResponse = _userRepository.FindUser(foundUserRequest);

        //     return userResponse;
        // }

        // public Task<List<UserResponse>> GetAllUsers()
        // {
        //     var users = _userRepository.GetAllUsers();

        //     return users;
        // }

        // public Task<UserResponse> UpdateUser(UpdatedUserRequest updatedUserRequest)
        // {
        //     var userResponse = _userRepository.UpdateUser(updatedUserRequest);

        //     return userResponse;
        // }
        public Task<FoundUserResponse> CreateUser(CreatedUserRequest createdUserRequest)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUser(FoundUserRequest foundUserRequest)
        {
            throw new NotImplementedException();
        }

        public Task<FoundUserResponse> FindUser(FoundUserRequest foundUserRequest)
        {
            throw new NotImplementedException();
        }

        public Task<List<FoundUserResponse>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<FoundUserResponse> UpdateUser(UpdatedUserRequest updatedUserRequest)
        {
            throw new NotImplementedException();
        }
    }
}