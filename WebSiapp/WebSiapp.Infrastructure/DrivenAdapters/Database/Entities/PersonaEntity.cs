using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSiapp.Infrastructure.DrivenAdapters.Database.Entities;

[Table("Persona", Schema = "PRUEBA")]
public class PersonaEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [StringLength(200)] public string Nombre { get; set; }

    [StringLength(200)] public string Apellido { get; set; }
    [EmailAddress] public string Email { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    [StringLength(200)] public string Ocupación { get; set; }
}
