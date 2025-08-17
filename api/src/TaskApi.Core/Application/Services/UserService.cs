using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.DTOs.Responses;
using TaskApi.Core.Application.Interfaces;
using TaskApi.Core.Application.Mappings;
using TaskApi.Core.Domain.Exception;

namespace TaskApi.Core.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserResponse> CreateUser(CreatedUserRequest createdUserRequest)
        {
            var userResponse = await _userRepository.CreateUser(UserProfile.UserAssembler(createdUserRequest));

            return UserProfile.UserResponseAssembler(userResponse);
        }

        public async Task<bool> DeleteUser(FoundUserBase foundUserBase)
        {
            var foundUserResponse = await FindUser(foundUserBase);

            var isDeleted = await _userRepository.DeleteUser(UserProfile.FoundUserRequestAssembler(foundUserResponse));

            return isDeleted;
        }

        public async Task<FoundUserResponse> FindUser(FoundUserBase foundUserBase)
        {
            var user = await _userRepository.FindUser(foundUserBase);

            if (user == null)
            {
                throw new UserNotFoundException(foundUserBase.Id);
            }

            return UserProfile.FoundUserResponseAssembler(user);
        }

        public async Task<List<UserResponse>> GetAllUsers()
        {
            var users = await _userRepository.GetAllUsers();

            return UserProfile.UsersResponseAssembler(users);
        }

        public async Task<UserResponse> UpdateUser(UpdatedUserRequest updatedUserRequest)
        {
            var user = await _userRepository.UpdateUser(updatedUserRequest);

            return UserProfile.UserResponseAssembler(user);
        }
    }
}