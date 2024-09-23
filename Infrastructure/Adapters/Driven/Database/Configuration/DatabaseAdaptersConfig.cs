using Domain.Ports.Driven;
using Infrastructure.Adapters.Driven.Database.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Adapters.Driven.Database.Configuration;

public static class DatabaseAdaptersConfig
{
    // configurar contenedor de dependencias para usarlo en Program.cs
     public static void AddDatabase(this IServiceCollection services, string databaseConnection)
        {
        services.AddDbContext<FacturacionContext>(options => options.UseSqlServer(databaseConnection));

            services.AddScoped<IDteRepository, DteRepository>();
        }
}