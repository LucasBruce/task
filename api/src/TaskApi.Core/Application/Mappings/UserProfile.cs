using TaskApi.Core.Application.DTOs.Responses;
using TaskApi.Core.Domain.Entities;
using AutoMapper;

namespace TaskApi.Core.Application.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<FoundUserResponse, User>();

            CreateMap<User, UserResponse>();
        }
    }
}