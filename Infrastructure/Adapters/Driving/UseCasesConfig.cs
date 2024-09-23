using Domain.Ports.Driving;
using Domain.UseCases;

namespace Infrastructure.Adapters.Driving;

public static class UseCasesConfig
{
    public static void AddUseCases(this IServiceCollection services)
    {
        services.AddTransient<IRegisterDte, RegisterDte>();
    }
}
