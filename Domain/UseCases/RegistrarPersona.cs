using Domain.Models;
using Domain.Ports.Driven;
using Domain.Ports.Driving;

namespace Domain.UseCases;

public class RegistrarPersona : IRegisterPersona
{
    private readonly IPersonaRepository _personaRepository;

    public RegistrarPersona(IPersonaRepository personaRepository)
    {
        _personaRepository = personaRepository;
    }

    public Task<PersonaModel?> Execute(PersonaModel personaModel)
    {
        var personaGuardada = _personaRepository.AddPersona(personaModel);

        if (personaGuardada.Result == null)
        {
            throw new Exception("No se pudo registrar el persona");
        }

        return personaGuardada;
    }
}