using ErrorOr;
using WebSiapp.Domain.Common.Errors;
using WebSiapp.Domain.Models;
using WebSiapp.Domain.Ports.Driven;
using WebSiapp.Domain.Ports.Driving;

namespace WebSiapp.Domain.UseCases;

public class GetPersona : IConsultarPersona
{
    private readonly IPersonaRepository _personaRepository;

    public GetPersona(IPersonaRepository personaRepository)
    {
        _personaRepository = personaRepository;
    }

    public async Task<ErrorOr<PersonaModel>> Execute(int idPersona)
    {
        var createdPersona = await _personaRepository.GetPersonaById(idPersona);

        if (createdPersona is null)
        {
            return Errors.Persona.NotFoundPersona(idPersona);
        }

        return createdPersona;
    }
}
