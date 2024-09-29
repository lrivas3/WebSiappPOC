using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.DrivenAdapters.Database.Entities;

[Table("Persona")]
public class PersonaEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [StringLength(200)] public string Nombre { get; set; }

    [StringLength(200)] public string Apellido { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    [StringLength(200)] public string Ocupación { get; set; }
}