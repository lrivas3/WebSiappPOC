using Domain.Models;

namespace Domain.Ports.Driving;

public interface IRegisterPersona
{
    Task<Persona> Execute(Persona persona);
}