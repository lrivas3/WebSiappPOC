using AutoMapper;
using WebSiapp.Domain.Models;
using WebSiapp.Infrastructure.DrivingAdapters.Dtos.Response;

namespace WebSiapp.Infrastructure.DrivenAdapters.Database.Entities.Mappings;

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
