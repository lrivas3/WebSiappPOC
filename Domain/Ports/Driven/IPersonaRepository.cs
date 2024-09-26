using Domain.Models;

namespace Domain.Ports.Driven;

public interface IPersonaRepository
{
    Task<PersonaModel?> GetPersonaById(int id);
    Task<PersonaModel?> AddPersona(PersonaModel persona);
}