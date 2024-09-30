using ErrorOr;
using WebSiapp.Domain.Models;

namespace WebSiapp.Domain.Ports.Driving;

public interface IRegisterPersona
{
    Task<ErrorOr<PersonaModel?>> Execute(PersonaModel personaModel);
}