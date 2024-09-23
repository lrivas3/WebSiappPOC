using Infrastructure.Adapters.Driven.Database.Models;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Adapters.Driven.Database;

public class FacturacionContext : DbContext
{
    
    public FacturacionContext(DbContextOptions<FacturacionContext> options) : base(options)
    {
    }

    public DbSet<DteEntity> Dtes { get; set; }
}