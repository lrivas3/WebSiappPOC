using Domain.Ports.Driving;
using Domain.UseCases;

namespace Infrastructure.DrivingAdapters;

public static class UseCasesConfig
{
    public static void AddUseCases(this IServiceCollection services)
    {
        services.AddScoped<IRegisterPersona, RegistrarPersona>();
        services.AddScoped<IConsultarPersona, GetPersona>();
    }
}
