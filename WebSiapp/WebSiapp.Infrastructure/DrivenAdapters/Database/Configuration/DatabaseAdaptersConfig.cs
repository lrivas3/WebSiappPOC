using WebSiapp.Application.Ports.Driven;
using Microsoft.EntityFrameworkCore;
using WebSiapp.Infrastructure.DrivenAdapters.Database.Repositories;

namespace WebSiapp.Infrastructure.DrivenAdapters.Database.Configuration;

public static class DatabaseAdaptersConfig
{
    public static void AddPersistance(this IServiceCollection services, string databaseConnection)
    {
        services.AddDbContext<PruebaConceptoContext>(options => options.UseSqlServer(databaseConnection));
        services.AddScoped<IPersonaRepository, PersonaRepository>();
    }
}
