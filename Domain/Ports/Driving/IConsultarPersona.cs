using Domain.Models;
using ErrorOr;

namespace Domain.Ports.Driving;

public interface IConsultarPersona
{
    Task<ErrorOr<PersonaModel>> Execute(int idPersona);
}