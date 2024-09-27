using Domain.Models;
using ErrorOr;
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

    public async Task<ErrorOr<PersonaModel?>> Execute(PersonaModel personaModel)
    {
        var guardarPersonaResult = await _personaRepository.AddPersona(personaModel);

        if (guardarPersonaResult.IsError)
        {
            return guardarPersonaResult.Errors;
        }

        return guardarPersonaResult.Value;
    }
}