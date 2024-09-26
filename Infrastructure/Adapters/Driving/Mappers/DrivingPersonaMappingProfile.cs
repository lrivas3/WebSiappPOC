using AutoMapper;
using Domain.Models;
using Infrastructure.Adapters.Driving.Dtos;
using Infrastructure.Adapters.Driving.Dtos.Request;

namespace Infrastructure.Adapters.Driving.Mappers;

public class DrivingPersonaMappingProfile : Profile
{

    public DrivingPersonaMappingProfile()
    {
        CreateMap<RegistrarPersonaRequestDto, PersonaModel>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());
    }
}