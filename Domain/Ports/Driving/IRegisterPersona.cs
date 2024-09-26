using Domain.Models;

namespace Domain.Ports.Driving;

public interface IRegisterPersona
{
    Task<PersonaModel?> Execute(PersonaModel personaModel);
}