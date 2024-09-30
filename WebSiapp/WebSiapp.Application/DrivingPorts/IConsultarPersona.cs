using ErrorOr;
using WebSiapp.Domain.Models;

namespace WebSiapp.Application.DrivingPorts;

public interface IConsultarPersona
{
    Task<ErrorOr<PersonaModel>> Execute(int idPersona);
}