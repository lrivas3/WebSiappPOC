using AutoMapper;
using Domain.Models;
using Infrastructure.DrivingAdapters.Dtos.Response;

namespace Infrastructure.DrivenAdapters.Database.Entities.Mappings;

public class PersonaMappingProfile : Profile
{
    public PersonaMappingProfile() {
                // convertir desde repo a entidad bd
                CreateMap<PersonaModel, PersonaEntity>()
                    .ReverseMap();
                // devolver al dominio desde repo
                CreateMap<PersonaEntity, PersonaModel>()
                    .ReverseMap();
                
                CreateMap<PersonaModel,RegistrarPersonaResponseDto>()
                    .ReverseMap();
                
                CreateMap<PersonaModel,PersonaGetResultDto>()
                    .ReverseMap();
    }
}
