using AutoMapper;

namespace TaskApi.Core.Application.Mappings
{
    public class AutoMapper<S, T> : Profile
    {
        public AutoMapper()
        {
            CreateMap<S, T>();
        }   
    }

}