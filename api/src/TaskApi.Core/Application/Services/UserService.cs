using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.DTOs.Responses;
using TaskApi.Core.Application.Interfaces;
using TaskApi.Core.Domain.Entities;
using AutoMapper;

namespace TaskApi.Core.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;

            _mapper = mapper;
        }

        public async Task<UserResponse> CreateUser(CreatedUserRequest createdUserRequest)
        {
            var user = _mapper.Map<User>(createdUserRequest);

            var userResponse = await _userRepository.CreateUser(user);

            var userResponseDto = _mapper.Map<UserResponse>(userResponse);

            return userResponseDto;
        }

        public async Task<bool> DeleteUser(FoundUserRequest foundUserRequest)
        {
            var foundUser = await FindUser(foundUserRequest);

            var foundUserDto = _mapper.Map<FoundUserRequest>(foundUser);

            var isDeleted = await _userRepository.DeleteUser(foundUserDto);

            return isDeleted;
        }

        public async Task<FoundUserResponse> FindUser(FoundUserRequest foundUserRequest)
        {
            var user = await _userRepository.FindUser(foundUserRequest);

            var userResponse = _mapper.Map<FoundUserResponse>(user);

            return userResponse;
        }

        public async Task<List<UserResponse>> GetAllUsers()
        {
            var users = await _userRepository.GetAllUsers();

            var userResponses = _mapper.Map<List<UserResponse>>(users);

            return userResponses;
        }

        public async Task<UserResponse> UpdateUser(UpdatedUserRequest updatedUserRequest)
        {
            var user = await _userRepository.UpdateUser(updatedUserRequest);

            var userResponse = _mapper.Map<UserResponse>(user);

            return userResponse;
        }
    }
}