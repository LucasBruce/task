using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.DTOs.Responses;
using TaskApi.Core.Application.Interfaces;

namespace TaskApi.Core.Application.Services
{
    public class DutyService : IDutyService
    {
        private readonly IDutyRepository _dutyRepository;

        public DutyService(IDutyRepository dutyRepository)
        {
            _dutyRepository = dutyRepository;
        }

        public Task<DutyResponse> CreateDuty(CreatedDutyRequest createdDutyRequest)
        {
            var dutyResponse = _dutyRepository.CreateDuty(createdDutyRequest);

            return dutyResponse;
        }

        public Task<bool> DeleteDuty(FoundDutyRequest foundDutyRequest)
        {
            var isDeleted = _dutyRepository.DeleteDuty(foundDutyRequest);

            return isDeleted;
        }

        public Task<DutyResponse> FindDuty(FoundDutyRequest foundDutyRequest)
        {
            var dutyResponse = _dutyRepository.FindDuty(foundDutyRequest);

            return dutyResponse;
        }

        public Task<List<DutyResponse>> GetAllDuties()
        {
            var duties = _dutyRepository.GetAllDuties();

            return duties;
        }

        public Task<DutyResponse> UpdateDuty(UpdatedDutyRequest updatedDutyRequest)
        {
            var dutyResponse = _dutyRepository.UpdateDuty(updatedDutyRequest);

            return dutyResponse;
        }
    }
}