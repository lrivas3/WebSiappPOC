using WebSiapp.Application.UseCases;
using WebSiapp.Domain.Ports.Driving;

namespace WebSiapp.Infrastructure.DrivingAdapters;

public static class UseCasesConfig
{
    public static void AddUseCases(this IServiceCollection services)
    {
        services.AddScoped<IRegisterPersona, RegistrarPersona>();
        services.AddScoped<IConsultarPersona, GetPersona>();
    }
}
