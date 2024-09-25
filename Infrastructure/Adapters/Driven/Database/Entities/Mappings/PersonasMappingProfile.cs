using AutoMapper;
using Domain.Models;

namespace Infrastructure.Adapters.Driven.Database.Entities.Mappings;

public class PersonaMappingProfile : Profile
{
    public PersonaMappingProfile() {
                CreateMap<Persona, PersonaEntity>()
                    .ForMember(dest => dest.Id, opt => opt.Ignore())
                    .ReverseMap();
    }
}
