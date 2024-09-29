using System.Diagnostics;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Infrastructure.Filters;

public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        var exception = context.Exception;

        var problemDetails = new ProblemDetails()
        {
            Title = "Internal Server Error",
            Detail = "An error occurred while processing your request. Please contact support if the problem persists.",
            Status = (int)HttpStatusCode.InternalServerError,
        };

        context.Result = new ObjectResult(problemDetails);

        context.ExceptionHandled = true;
    }
}
