using ErrorOr;
using WebSiapp.Application.Ports.Driven;
using WebSiapp.Domain.Models;
using WebSiapp.Domain.Ports.Driving;

namespace WebSiapp.Application.UseCases;

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
