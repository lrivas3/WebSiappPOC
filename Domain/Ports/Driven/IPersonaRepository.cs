using Domain.Models;
using ErrorOr;

namespace Domain.Ports.Driven;

public interface IPersonaRepository
{
    Task<ErrorOr<PersonaModel?>> GetPersonaById(int id);
    Task<ErrorOr<PersonaModel?>> AddPersona(PersonaModel persona);
}