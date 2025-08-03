using TaskApi.Core.Domain.Entities;
using TaskApi.Core.Application.Interfaces;
using TaskApi.Infrastructure.TestsDoubles.Stubs;
using TaskApi.Core.Application.DTOs.Requests;

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

        public Task<bool> DeleteUser(FoundUserRequest foundUserRequest)
        {
            var userR = FindUser(foundUserRequest).Result;

            _users.Remove(userR);

            return Task.FromResult(true);
        }

        public Task<User> FindUser(FoundUserRequest foundUserRequest)
        {
            var foundUser = _users.FirstOrDefault(element => element.Id == foundUserRequest.Id);

            if (foundUser == null)
            {
                throw new NotImplementedException();
            }

            return Task.FromResult(foundUser);
        }

        public Task<List<User>> GetAllUsers()
        {
            return Task.FromResult(_users);
        }

        public Task<User> UpdateUser(UpdatedUserRequest updatedUserRequest)
        {
            var user = _users.FirstOrDefault(element => element.Id == updatedUserRequest.Id);

            if (user == null)
            {
                throw new NotImplementedException();
            }

            user.Id = updatedUserRequest.Id;
            user.Name = updatedUserRequest.Name;
            user.CorporateEmail = updatedUserRequest.CorporateEmail;
            user.Job = updatedUserRequest.Job;
            user.Duties = updatedUserRequest.Duties ?? new List<Duty>();

            return Task.FromResult(UpdatedUser);
        }
    }
}
