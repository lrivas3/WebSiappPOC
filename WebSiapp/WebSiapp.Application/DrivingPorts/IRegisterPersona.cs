using ErrorOr;
using WebSiapp.Domain.Models;

namespace WebSiapp.Application.DrivingPorts;

public interface IRegisterPersona
{
    Task<ErrorOr<PersonaModel?>> Execute(PersonaModel personaModel);
}