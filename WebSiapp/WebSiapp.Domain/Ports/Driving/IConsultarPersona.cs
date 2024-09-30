using ErrorOr;
using WebSiapp.Domain.Models;

namespace WebSiapp.Domain.Ports.Driving;

public interface IConsultarPersona
{
    Task<ErrorOr<PersonaModel>> Execute(int idPersona);
}