using TaskApi.Core.Application.DTOs.Responses;
using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Domain.Entities;

namespace TaskApi.Core.Application.Mappings
{
    public static class DutyProfile
    {
        private static Status _statusAssembler(CreateDutyStatus createDutyStatus)
        {
            var (pending, inProgress, completed) = createDutyStatus with { };

            return new Status
            (
                Pending: pending,
                InProgress: inProgress,
                Completed: completed
            );
        }

        public static Owner OwnerAssembler(User user)
        {
            var (Id, Name, Job) = user with { };

            return new Owner
            (
                Id,
                Name,
                Job
            );
        }

        public static Duty DutyAssembler(CreatedDutyRequest createdDutyRequest)
        {
            var (title, description, dueDate, status, user) = createdDutyRequest with { };

            return new Duty(
                Guid.NewGuid(),
                title,
                description,
                dueDate,
                _statusAssembler(status),
                UserProfile.UserAssembler(user)
            );
        }

        public static DutyResponse DutyResponseAssembler(Duty duty)
        {
            var (id, title, description, user) = duty with { };

            return new DutyResponse(
                id,
                title,
                description,
                OwnerAssembler(user)
            );
        }

        public static List<DutyResponse> DutiesResponseAssembler(List<Duty> duties)
        {
            List<DutyResponse> dutiesResponse = new List<DutyResponse>();

            foreach (var duty in duties)
            {
                dutiesResponse.Add(DutyResponseAssembler(duty));
            }

            return dutiesResponse;
        }

        public static FoundDutyResponse FoundDutyResponseAssembler(Duty duty)
        {
            var (id, title, description, dueDate, status, user) = duty with { };

            return new FoundDutyResponse(
                id,
                title,
                description,
                dueDate,
                status,
                UserProfile.UserResponseAssembler(user)
            );
        }
    }
}
             