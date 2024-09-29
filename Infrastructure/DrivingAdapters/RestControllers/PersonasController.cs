using System.Net.Mime;
using AutoMapper;
using Domain.Models;
using Domain.Ports.Driving;
using ErrorOr;
using Infrastructure.DrivingAdapters.Dtos.Request;
using Infrastructure.DrivingAdapters.Dtos.Response;
using Microsoft.AspNetCore.Mvc;

namespace Infrastructure.DrivingAdapters.RestControllers;

// Los controllers actuarian como adapters pero mejor que se llamen por convencion
// como controllers porque sino no podemos usar [controller] para simplificar la ruta, hasta donde se
[ApiController]
[Produces(MediaTypeNames.Application.Json)]
[Route("api/[controller]")]
public class PersonasController : ControllerBase
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
        try
        {
            var personaCreateRequest = _mapper.Map<PersonaModel>(personaDto);
            
            var registeredPersona = await _registerPersona.Execute(personaCreateRequest);

            var personaResponse = _mapper.Map<RegistrarPersonaResponseDto>(registeredPersona);

            return Ok(personaResponse);
        }
        catch(Exception ex)
        {
            // ignored
            return Problem(ex.ToString());
        }
    }

    [HttpGet("{id}")]
    public async Task<ErrorOr<IActionResult>> Get(int id)
    {
        try
        {
            var getPersonaRequest = await _consultarPersona.Execute(id);

            if (getPersonaRequest.IsError)
            {
            }
            
            var mappedPersonResponse = _mapper.Map<RegistrarPersonaResponseDto>(getPersonaRequest.Value);
            
            return Ok(mappedPersonResponse);
        }
        catch (Exception e)
        {
            return Problem(e.InnerException.ToString());
        }
    }
}
