﻿namespace WebSiapp.Domain.Models;

public class PersonaModel
{
    public int Id { get; set; }

    public string Nombre { get; set; }

    public string Apellido { get; set; }

    public string Email { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string Ocupación { get; set; }
}
