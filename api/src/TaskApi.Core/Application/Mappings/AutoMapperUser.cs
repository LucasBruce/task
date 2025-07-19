using AutoMapper;
using TaskApi.Core.Domain.Entities;
using TaskApi.Core.Application.DTOs.Responses;

namespace TaskApi.Core.Application.Mappings
{
    public class AutoMapperUser : Profile
    {
        public AutoMapperUser()
        {
            CreateMap<User, UserResponse>();
            CreateMap<UserResponse, User>();
        }
        
    }

}