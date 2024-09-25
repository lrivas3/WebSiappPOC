using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Adapters.Driven.Database.Entities;

[Table("Empresa")]
public class Empresa
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required] [StringLength(200)] public string Nombre { get; set; }

    [StringLength(50)] public string Telefono { get; set; }

    [StringLength(200)] public string Direccion { get; set; }
}