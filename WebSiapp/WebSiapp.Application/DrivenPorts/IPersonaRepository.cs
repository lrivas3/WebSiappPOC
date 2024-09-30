using WebSiapp.Domain.Models;

namespace WebSiapp.Application.DrivenPorts;

public interface IPersonaRepository
{
    Task<PersonaModel?> GetPersonaById(int id);
    Task<PersonaModel?> AddPersona(PersonaModel persona);
    Task<PersonaModel?> FindByEmail(string personaModelEmail);
}
