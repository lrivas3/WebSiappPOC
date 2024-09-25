using Domain.Models;

namespace Domain.Ports.Driven;

public interface IPersonaRepository
{
    Task<Persona?> GetPersonaById(int id);
}