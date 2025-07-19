using AutoMapper;
using TaskApi.Core.Domain.Entities;
using TaskApi.Core.Application.DTOs.Responses;

namespace TaskApi.Core.Application.Mappings
{
    public class AutoMapperDuty : Profile
    {
        public AutoMapperDuty()
        {
            CreateMap<Duty, DutyResponse>();
            CreateMap<DutyResponse, Duty>();
        }
        
    }

}