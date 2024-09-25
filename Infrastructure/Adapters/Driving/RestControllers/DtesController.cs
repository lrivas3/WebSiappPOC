using System.Net.Mime;
using Domain.Ports.Driving;
using Microsoft.AspNetCore.Mvc;

namespace Infrastructure.Adapters.Driving.RestControllers;

// Los controllers actuarian como adapters pero mejor que se llamen por convencion
// como controllers porque sino no podemos usar [controller] para simplificar la ruta, hasta donde se
[ApiController]
[Produces(MediaTypeNames.Application.Json)]
[Route("api/[controller]")]
public class DtesController : ControllerBase
{
    private readonly IRegisterPersona _registerPersona;

    public DtesController(IRegisterPersona registerPersona)
    {
        _registerPersona = registerPersona;
    }

    [HttpPost("{tipoDte}")]
    public IActionResult RegisterDte(string tipoDte)
    {
        try
        {
            var registeredId = _registerPersona.Execute(tipoDte);

            return Ok(new {Id = registeredId, SomethingElse = registeredId });
        }
        catch
        {
            // ignored
            return Problem("not yet well thought out");
        }
    }
}