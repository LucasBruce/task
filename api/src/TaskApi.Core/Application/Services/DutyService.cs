using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.DTOs.Responses;
using TaskApi.Core.Application.Interfaces;
using TaskApi.Core.Domain.Entities;
using AutoMapper;

namespace TaskApi.Core.Application.Services
{
    public class DutyService : IDutyService
    {
        private readonly IMapper _mapper;

        private readonly IDutyRepository _dutyRepository;

        public DutyService(IDutyRepository dutyRepository, IMapper mapper)
        {
            _mapper = mapper;
            _dutyRepository = dutyRepository;
        }

        public async Task<DutyResponse> CreateDuty(CreatedDutyRequest createdDutyRequest)
        {
            var duty = _mapper.Map<Duty>(createdDutyRequest);

            var dutyReturn = await _dutyRepository.CreateDuty(duty);

            var dutyResponse = _mapper.Map<DutyResponse>(dutyReturn);

            return dutyResponse;
        }

        public async Task<bool> DeleteDuty(FoundDutyRequest foundDutyRequest)
        {
            var isDeleted = await _dutyRepository.DeleteDuty(foundDutyRequest);

            return isDeleted;
        }

        public async Task<FoundDutyResponse> FindDuty(FoundDutyRequest foundDutyRequest)
        {
            var duty = await _dutyRepository.FindDuty(foundDutyRequest);

            var dutyResponse = _mapper.Map<FoundDutyResponse>(duty);

            return dutyResponse;
        }

        public async Task<List<DutyResponse>> GetAllDuties()
        {
            var duties = await _dutyRepository.GetAllDuties();

            List<DutyResponse> dutiesResponses = _mapper.Map<List<DutyResponse>>(duties);

            return dutiesResponses;
        }

        public async Task<DutyResponse> UpdateDuty(UpdatedDutyRequest updatedDutyRequest)
        {
            var duty = await _dutyRepository.UpdateDuty(updatedDutyRequest);

            var dutyResponse = _mapper.Map<DutyResponse>(duty);

            return dutyResponse;
        }
    }
}
