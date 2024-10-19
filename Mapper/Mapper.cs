using AutoMapper;
using FullstackBeatsBE.DTO;
using FullstackBeatsBE.Models;

namespace FullstackBeatsBE.Mapper
{
    public class Mapper
    {
        public class MappingProfile : Profile
        {
            public MappingProfile()
            {
                CreateMap<Show, CreateShowDTO>().ReverseMap();
                CreateMap<Show, UpdateShowDTO>().ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId)).ReverseMap();

            }

        }
    }
}
