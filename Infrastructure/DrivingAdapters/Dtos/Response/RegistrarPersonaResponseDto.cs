namespace Infrastructure.DrivingAdapters.Dtos.Response;

public class RegistrarPersonaResponseDto
{
    public int Id { get; set; }
    public string Nombre { get; set; }

    public string Apellido { get; set; }

    public DateTime? FechaNacimiento { get; set; }
    public string Email { get; set; }

    public string Ocupación { get; set; }
}
