using AutoMapper;
using WebSiapp.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using WebSiapp.Application.DrivingPorts;
using WebSiapp.Infrastructure.DrivingAdapters.Dtos.Request;
using WebSiapp.Infrastructure.DrivingAdapters.Dtos.Response;

namespace WebSiapp.Infrastructure.DrivingAdapters.RestControllers;

[Route("api/[controller]")]
public class PersonasController : ApiController
{
    private readonly IRegisterPersona _registerPersona;
    private readonly IConsultarPersona _consultarPersona;
    private readonly IMapper _mapper;

    public PersonasController(IRegisterPersona registerPersona, IMapper mapper, IConsultarPersona consultarPersona)
    {
        _registerPersona = registerPersona;
        _mapper = mapper;
        _consultarPersona = consultarPersona;
    }

    [HttpPost]
    public async Task<IActionResult> RegistrarPersona(RegistrarPersonaRequestDto personaDto)
    {
        var personaCreateRequest = _mapper.Map<PersonaModel>(personaDto);

        var registeredPersona = await _registerPersona.Execute(personaCreateRequest);

        return registeredPersona.Match(
            result => Ok(_mapper.Map<RegistrarPersonaResponseDto>(result)),
            Problem
        );
    }

    [HttpPost("Excepcion")]
    public IActionResult TestException()
    {
        throw new Exception("Probando Excepciones");
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var getPersonaResult = await _consultarPersona.Execute(id);
        return getPersonaResult.Match(
            persona => Ok(MapToPersonaResponse(persona)),
            errors => Problem(errors)
        );
    }

    private RegistrarPersonaResponseDto MapToPersonaResponse(PersonaModel result)
    {
        return _mapper.Map<RegistrarPersonaResponseDto>(result);
    }
}
