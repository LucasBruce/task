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

        public static Duty DutyAssembler(CreatedDutyRequest createdDutyRequest)
        {
            var (title, description, dueDate, status, owner) = createdDutyRequest with { };

            var (id, name, corporateEmail, job) = (owner ?? new Owner())with { };

            return new Duty
            {
                Id = Guid.NewGuid(),
                Title = title ?? string.Empty,
                Description = description ?? string.Empty,
                DueDate = dueDate,
                Status = _statusAssembler(status),
                Owner = new Owner
                {
                    Id = id,
                    Name = name,
                    CorporateEmail = corporateEmail,
                    Job = job,
                }
            };
        }

        public static DutyResponse DutyResponseAssembler(Duty duty)
        {

            var (id, title, description, owner) = duty with { };

            return new DutyResponse(
                id,
                title,
                description,
                owner
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
            var (id, title, description, dueDate, status, owner) = duty with { };

            return new FoundDutyResponse(
                id,
                title,
                description,
                dueDate,
                status,
                owner
            );
        }
    }
}
