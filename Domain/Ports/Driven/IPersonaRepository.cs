using Domain.Models;
using ErrorOr;

namespace Domain.Ports.Driven;

public interface IPersonaRepository
{
    Task<PersonaModel?> GetPersonaById(int id);
    Task<PersonaModel?> AddPersona(PersonaModel persona);
    Task<PersonaModel?> FindByEmail(string personaModelEmail);
}
