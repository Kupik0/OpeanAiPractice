using AutoMapper;
using WebApi.Dto;
using WebApi.Entities;

namespace WebApi.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<User, UserDto>()
                .ReverseMap();

        
        }
    }
}
