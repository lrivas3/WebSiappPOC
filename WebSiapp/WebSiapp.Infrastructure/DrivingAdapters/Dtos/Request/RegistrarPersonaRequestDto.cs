using System.ComponentModel.DataAnnotations;

namespace WebSiapp.Infrastructure.DrivingAdapters.Dtos.Request;

public class RegistrarPersonaRequestDto
{
    
    [StringLength(200)] public string Nombre { get; set; }

    [StringLength(200)] public string Apellido { get; set; }

    public DateTime? FechaNacimiento { get; set; }
    public string Email { get; set; }

    [StringLength(200)] public string Ocupación { get; set; }
}
