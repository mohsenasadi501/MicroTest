using AutoMapper;
using MicroTest.Dtos;
using MicroTest.Models;
using PlatformService.Dtos;

namespace MicroTest.Profiles
{
    public class PlatformProfile : Profile
    {
        public PlatformProfile()
        {
            //Source -> Target
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
            CreateMap<PlatformReadDto, PlatformPublishDto>();
        }
    }
}
