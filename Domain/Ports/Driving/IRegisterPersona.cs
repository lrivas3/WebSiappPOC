using Domain.Models;
using ErrorOr;

namespace Domain.Ports.Driving;

public interface IRegisterPersona
{
    Task<ErrorOr<PersonaModel?>> Execute(PersonaModel personaModel);
}