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
        var findResult = await _personaRepository.FindByEmail(personaModel.Email);

        if (findResult != null)
        {
            // Lo se, no se deberia hacer pero es para probar
            return Error.Conflict($"El correo electrónico {personaModel.Email} ya está registrado.");
        }

        var guardarPersonaResult = await _personaRepository.AddPersona(personaModel);

        return guardarPersonaResult;
    }
}
