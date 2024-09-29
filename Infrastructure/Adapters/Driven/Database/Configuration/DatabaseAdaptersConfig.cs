using Domain.Ports.Driven;
using Infrastructure.Adapters.Driven.Database.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Adapters.Driven.Database.Configuration;

public static class DatabaseAdaptersConfig
{
    public static void AddPersistance(this IServiceCollection services, string databaseConnection)
    {
        services.AddDbContext<PruebaConceptoContext>(options => options.UseSqlServer(databaseConnection));
        services.AddScoped<IPersonaRepository, PersonaRepository>();
    }
}