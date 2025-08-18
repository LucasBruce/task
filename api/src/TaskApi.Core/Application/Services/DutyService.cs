using TaskApi.Core.Application.DTOs.Responses;
using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.Interfaces;
using TaskApi.Core.Application.Mappings;
using TaskApi.Core.Domain.Exception;

namespace TaskApi.Core.Application.Services
{
    public class DutyService : IDutyService
    {
        private readonly IDutyRepository _dutyRepository;

        public DutyService(IDutyRepository dutyRepository)
        {
            _dutyRepository = dutyRepository;
        }

        public async Task<DutyResponse> CreateDuty(CreatedDutyRequest createdDutyRequest)
        {
            var duty = DutyProfile.DutyAssembler(createdDutyRequest);

            var dutyReturn = await _dutyRepository.CreateDuty(duty);

            return DutyProfile.DutyResponseAssembler(dutyReturn);
        }

        public async Task<bool> DeleteDuty(FoundDutyBase foundDutyBase)
        {
            var isDeleted = await _dutyRepository.DeleteDuty(foundDutyBase);

            return isDeleted;
        }

        public async Task<FoundDutyResponse> FindDuty(FoundDutyBase foundDutyBase)
        {
            var duty = await _dutyRepository.FindDuty(foundDutyBase);

            return DutyProfile.FoundDutyResponseAssembler(duty);
        }

        public async Task<List<DutyResponse>> GetAllDuties()
        {
            var duties = await _dutyRepository.GetAllDuties();

            return DutyProfile.DutiesResponseAssembler(duties);
        }

        public async Task<DutyResponse> UpdateDuty(UpdatedDutyRequest updatedDutyRequest)
        {
            var duty = await _dutyRepository.UpdateDuty(updatedDutyRequest);

            return DutyProfile.DutyResponseAssembler(duty);
        }
    }
}
