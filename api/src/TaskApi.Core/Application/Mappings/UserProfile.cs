using TaskApi.Core.Application.DTOs.Responses;
using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Domain.Entities;

namespace TaskApi.Core.Application.Mappings
{
    public static class UserProfile
    {

        public static User UserAssembler(CreatedUserRequest createdUserRequest)
        {
            var (Name, CorporateEmail, Job, Duties) = createdUserRequest with { };

            return new User
            (
                Id: Guid.NewGuid(),
                Name: Name,
                CorporateEmail: CorporateEmail,
                Job: Job,
                Duties: Duties ?? new List<Duty>()
            );
        }

        public static UserResponse UserResponseAssembler(User user)
        {
            var userObj = user with { };

            var (id, name, job) = userObj;

            return new UserResponse
            (
                 id,
                 name,
                 job,
                 DutyProfile.DutiesResponseAssembler(userObj.Duties)
            );
        }

        public static List<UserResponse> UsersResponseAssembler(List<User> users)
        {
            List<UserResponse> usersResponse = new List<UserResponse>();

            foreach (var user in users)
            {
                usersResponse.Add(UserResponseAssembler(user));
            }

            return usersResponse;
        }

        public static FoundUserResponse FoundUserResponseAssembler(User user)
        {
            var (id, name, corporateEmail, job, duties) = user with { };

            return new FoundUserResponse
            (
                id,
                name,
                corporateEmail,
                job,
                DutyProfile.DutiesResponseAssembler(duties)
            );
        }

        public static FoundUserRequest FoundUserRequestAssembler(FoundUserResponse foundUserResponse)
        {
            var (id, name, corporateEmail) = foundUserResponse with { };

            return new FoundUserRequest
            (
                id,
                name,
                corporateEmail
            );
        }

        public static FoundUserRequest FoundUserRequestAssembler(UpdatedUserRequest updatedUserRequest)
        {
            var (id, name, corporateEmail) = updatedUserRequest with { };

            return new FoundUserRequest
            (
                id,
                name ?? "",
                corporateEmail ?? ""
            );
        }
    }
}