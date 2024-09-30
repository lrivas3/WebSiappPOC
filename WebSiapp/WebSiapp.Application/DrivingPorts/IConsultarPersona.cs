using ErrorOr;
using WebSiapp.Domain.Models;

namespace WebSiapp.Application.Ports.DrivingPorts;

public interface IConsultarPersona
{
    Task<ErrorOr<PersonaModel>> Execute(int idPersona);
}