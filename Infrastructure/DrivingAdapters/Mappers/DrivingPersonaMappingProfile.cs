using AutoMapper;
using Domain.Models;
using Infrastructure.DrivingAdapters.Dtos.Request;

namespace Infrastructure.DrivingAdapters.Mappers;

public class DrivingPersonaMappingProfile : Profile
{
    public DrivingPersonaMappingProfile()
    {
        CreateMap<RegistrarPersonaRequestDto, PersonaModel>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());
    }
}