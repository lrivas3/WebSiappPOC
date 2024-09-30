using ErrorOr;
using WebSiapp.Application.DrivenPorts;
using WebSiapp.Application.DrivingPorts;
using WebSiapp.Domain.Common.Errors;
using WebSiapp.Domain.Models;

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
            return Errors.Persona.NotFoundPersona(personaModel.Id);
        }

        var guardarPersonaResult = await _personaRepository.AddPersona(personaModel);

        return guardarPersonaResult;
    }
}
