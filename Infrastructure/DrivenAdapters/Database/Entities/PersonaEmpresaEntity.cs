using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.DrivenAdapters.Database.Entities;

[Table("PersonaEmpresa")]
public class PersonaEmpresaEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [ForeignKey("Persona")] public int IdPersona { get; set; }

    [ForeignKey("Empresa")] public int IdEmpresa { get; set; }

    public DateTime? FechaContrato { get; set; }

    public DateTime? FechaFinContrato { get; set; }

    public virtual PersonaEntity PersonaEntity { get; set; }
    public virtual EmpresaEntity EmpresaEntity { get; set; }
}