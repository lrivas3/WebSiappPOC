using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Adapters.Driving.Dtos.Request;

public class RegistrarPersonaRequestDto
{
    
    [StringLength(200)] public string Nombre { get; set; }

    [StringLength(200)] public string Apellido { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    [StringLength(200)] public string Ocupación { get; set; }
}