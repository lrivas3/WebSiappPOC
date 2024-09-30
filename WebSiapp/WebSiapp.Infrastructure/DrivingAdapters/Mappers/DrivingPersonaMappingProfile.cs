using AutoMapper;
using WebSiapp.Domain.Models;
using WebSiapp.Infrastructure.DrivingAdapters.Dtos.Request;

namespace WebSiapp.Infrastructure.DrivingAdapters.Mappers;

public class DrivingPersonaMappingProfile : Profile
{
    public DrivingPersonaMappingProfile()
    {
        CreateMap<RegistrarPersonaRequestDto, PersonaModel>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());
    }
}