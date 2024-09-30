using ErrorOr;
using WebSiapp.Domain.Models;

namespace WebSiapp.Application.Ports.DrivingPorts;

public interface IRegisterPersona
{
    Task<ErrorOr<PersonaModel?>> Execute(PersonaModel personaModel);
}