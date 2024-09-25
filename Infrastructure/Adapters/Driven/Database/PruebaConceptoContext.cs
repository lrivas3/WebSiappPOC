using Infrastructure.Adapters.Driven.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Adapters.Driven.Database;

public class PruebaConceptoContext : DbContext
{
    public PruebaConceptoContext(DbContextOptions<PruebaConceptoContext> options) : base(options)
    {
    }

    public virtual DbSet<PersonaEntity?> Personas { get; set; }
    public virtual DbSet<Empresa> Empresas { get; set; }
    public virtual DbSet<PersonaEmpresa> PersonaEmpresas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PersonaEntity>();
    }
}