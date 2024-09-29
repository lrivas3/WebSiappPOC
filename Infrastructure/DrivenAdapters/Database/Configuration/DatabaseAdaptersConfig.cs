using Domain.Ports.Driven;
using Infrastructure.DrivenAdapters.Database.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DrivenAdapters.Database.Configuration;

public static class DatabaseAdaptersConfig
{
    public static void AddPersistance(this IServiceCollection services, string databaseConnection)
    {
        services.AddDbContext<PruebaConceptoContext>(options => options.UseSqlServer(databaseConnection));
        services.AddScoped<IPersonaRepository, PersonaRepository>();
    }
}