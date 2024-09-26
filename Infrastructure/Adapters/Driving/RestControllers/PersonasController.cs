using System.Net.Mime;
using AutoMapper;
using Domain.Models;
using Domain.Ports.Driving;
using static Microsoft.AspNetCore.Http.StatusCodes;
using Infrastructure.Adapters.Driving.Dtos.Request;
using Infrastructure.Adapters.Driving.Dtos.Response;
using Microsoft.AspNetCore.Mvc;

namespace Infrastructure.Adapters.Driving.RestControllers;

// Los controllers actuarian como adapters pero mejor que se llamen por convencion
// como controllers porque sino no podemos usar [controller] para simplificar la ruta, hasta donde se
[ApiController]
[Produces(MediaTypeNames.Application.Json)]
[Route("api/[controller]")]
public class PersonasController : ControllerBase
{
    private readonly IRegisterPersona _registerPersona;
    private readonly IMapper _mapper;

    public PersonasController(IRegisterPersona registerPersona, IMapper mapper)
    {
        _registerPersona = registerPersona;
        _mapper = mapper;
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
}
