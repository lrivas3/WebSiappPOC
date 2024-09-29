using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Infrastructure.DrivingAdapters.RestControllers;

public class ErrorsController : ControllerBase
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("/error")]
    public IActionResult Errors()
    {
        Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
        return Problem(title: exception?.Message, statusCode: 500, detail: exception?.InnerException?.Message);
    }
}
