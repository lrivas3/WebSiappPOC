using WebSiapp.Application.DrivingPorts;
using WebSiapp.Application.UseCases;

namespace WebSiapp.Infrastructure.DrivingAdapters;

public static class UseCasesConfig
{
    public static void AddUseCases(this IServiceCollection services)
    {
        services.AddScoped<IRegisterPersona, RegistrarPersona>();
        services.AddScoped<IConsultarPersona, GetPersona>();
    }
}
