using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.DTOs.Responses;
using TaskApi.Core.Domain.Entities;
using AutoMapper;

namespace TaskApi.Core.Application.Mappings
{
    public class DutyProfile : Profile
    {
        public DutyProfile()
        {
            CreateMap<CreatedDutyRequest, Duty>();
            
            CreateMap<Duty, FoundDutyResponse>();

            CreateMap<Duty, DutyResponse>()
            .ForMember(dest => dest.Owner, opt => opt
            .MapFrom(src => new Owner(
                src.User.Id,
                src.User.Name,
                src.User.Job
            )));
        }
    }

}