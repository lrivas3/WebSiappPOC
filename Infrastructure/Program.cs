using System.Reflection;
using Infrastructure.DrivenAdapters.Database.Configuration;
using Infrastructure.DrivingAdapters;
using Infrastructure.Errors;
using Infrastructure.Filters;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

ConfigurationManager configuration = builder.Configuration;
builder.Services.Configure<AppSettings>(configuration.GetSection(nameof(AppSettings)));
AppSettings appSettings = new();
configuration.GetSection(nameof(AppSettings)).Bind(appSettings);

// builder.Services.AddControllers(options => options.Filters.Add<ErrorHandlingFilterAttribute>());
builder.Services.AddControllers();
builder.Services.AddSingleton<ProblemDetailsFactory, WebSiappCustomProblemDetailsFactory>();
builder.Services.AddUseCases();
builder.Services.AddAutoMapper(Assembly.Load(typeof(Program).Assembly.GetName().Name!));
builder.Services.AddPersistance(appSettings.DatabaseConnection);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler("/error");
app.Map("/error", (HttpContext context) =>
{
    // Retrieve the exception
    Exception? exception = context.Features.Get<IExceptionHandlerFeature>()?.Error;

    // Create a dictionary for custom extensions
    var extensions = new Dictionary<string, object?>
    {
        { "traceId", context.TraceIdentifier },
        { "exceptionMessage", exception?.Message },
        { "stackTrace", exception?.StackTrace },
        { "customData", "Some additional info" }  // Add any custom data you want here
    };

    // You can also add conditional logic to include only certain fields if necessary
    if (context.User.Identity?.IsAuthenticated == true)
    {
        extensions.Add("userId", context.User.Identity.Name);
    }

    // Return a ProblemDetails with custom extensions
    return Results.Problem(
        detail: "An unexpected error occurred. Please try again later.",
        statusCode: StatusCodes.Status500InternalServerError,
        extensions: extensions
    );
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
