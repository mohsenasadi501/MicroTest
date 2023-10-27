using AutoMapper;
using MicroTest.Dtos;
using MicroTest.Models;

namespace MicroTest.Profiles
{
    public class PlatformProfile : Profile
    {
        public PlatformProfile()
        {
            //Source -> Target
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}
