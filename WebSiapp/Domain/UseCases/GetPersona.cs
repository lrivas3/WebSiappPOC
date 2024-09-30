using Domain.Common.Errors;
using Domain.Models;
using ErrorOr;
using Domain.Ports.Driven;
using Domain.Ports.Driving;

namespace Domain.UseCases;

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
