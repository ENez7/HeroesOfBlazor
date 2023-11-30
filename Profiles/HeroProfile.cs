using AutoMapper;
using HeroesOfBlazor.Dto;
using HeroesOfBlazor.Entities;

namespace HeroesOfBlazor.Profiles;

public class HeroProfile : Profile
{
    public HeroProfile()
    {
        CreateMap<CreateHeroDto, Hero>().ReverseMap();
        CreateMap<UpdateHeroDto, Hero>().ReverseMap();
    }
}