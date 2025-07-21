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
            var createdUser = new User
            {
                Name = user.Name,
                CorporateEmail = user.CorporateEmail,
                Job = user.Job,
                Duties = new List<Duty>()
            };

            _users.Add(createdUser);

            return Task.FromResult(createdUser);
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
            // var foundUser = _users.FirstOrDefault(element => element.Id == updatedUserRequest.Id);

            // if (foundUser == null)
            // {
            //     throw new NotImplementedException();
            // }

            // updatedUserRequest.Name = foundUser.Name ?? updatedUserRequest.Name;
            // updatedUserRequest.CorporateEmail = foundUser.CorporateEmail ?? updatedUserRequest.CorporateEmail;
            // updatedUserRequest.Job = foundUser.Job ?? updatedUserRequest.Job;
            // updatedUserRequest.Duties = updatedUserRequest.Duties ?? foundUser.Duties;

            return Task.FromResult(new User());
        }

    }
}