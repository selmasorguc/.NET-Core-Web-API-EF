using AutoMapper;
using Dtos.CharacterDtos;
using Models;

namespace _NET_Core_Web_API_EF
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<Character, AddCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<UpdateCharacterDto, GetCharacterDto>();
            CreateMap<GetCharacterDto, UpdateCharacterDto>();

        }
    }
}