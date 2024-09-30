using WebSiapp.Domain.Models;

namespace WebSiapp.Application.Ports.Driven;

public interface IPersonaRepository
{
    Task<PersonaModel?> GetPersonaById(int id);
    Task<PersonaModel?> AddPersona(PersonaModel persona);
    Task<PersonaModel?> FindByEmail(string personaModelEmail);
}
