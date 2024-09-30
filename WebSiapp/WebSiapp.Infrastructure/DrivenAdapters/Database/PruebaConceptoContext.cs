using Microsoft.EntityFrameworkCore;
using WebSiapp.Infrastructure.DrivenAdapters.Database.Entities;

namespace WebSiapp.Infrastructure.DrivenAdapters.Database;

public class PruebaConceptoContext : DbContext
{
    public PruebaConceptoContext(DbContextOptions<PruebaConceptoContext> options) : base(options)
    {
    }

    public DbSet<PersonaEntity> Personas { get; set; }
    public DbSet<EmpresaEntity> Empresas { get; set; }
    public DbSet<PersonaEmpresaEntity> PersonaEmpresas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PersonaEntity>();
    }
}