using TaskApi.Core.Domain.Entities;
using TaskApi.Core.Application.Interfaces;
using TaskApi.Infrastructure.TestsDoubles.Stubs;
using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Domain.Exception;

namespace TaskApi.Infrastructure.TestsDoubles.Fakes
{
    public class FakeUserRepository : IUserRepository
    {
        private readonly List<User> _users = UserStubs.GetAll();

        public Task<User> CreateUser(User user)
        {
            _users.Add(user);

            return Task.FromResult(user);
        }

        public Task<bool> DeleteUser(FoundUserBase foundUserBase)
        {
            var user = FindUser(foundUserBase).Result;

            return Task.FromResult(_users.Remove(user));
        }

        public Task<User> FindUser(FoundUserBase foundUserBase)
        {
            User? foundUser = null;

            foreach (var user in _users)
            {
                if (user.Id == foundUserBase.Id)
                {
                    foundUser = user;
                    break;
                }
            }

            if (foundUser == null)
            {
                throw new UserNotFoundException(foundUserBase.Id);
            }

            return Task.FromResult(foundUser);
        }

        public Task<List<User>> GetAllUsers()
        {
            return Task.FromResult(_users);
        }

        public Task<User> UpdateUser(UpdatedUserRequest updatedUserRequest)
        {
            var user = FindUser(updatedUserRequest).Result;

            user.Name = updatedUserRequest.Name ?? user.Name;
            user.CorporateEmail = updatedUserRequest.CorporateEmail ?? user.CorporateEmail;
            user.Job = updatedUserRequest.Job ?? user.Job;
            user.Duties = updatedUserRequest.Duties ?? user.Duties;

            return Task.FromResult(user);
        }
    }
}
