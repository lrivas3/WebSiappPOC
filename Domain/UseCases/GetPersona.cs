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
        var personaResult = await _personaRepository.GetPersonaById(idPersona);
        if (personaResult.Value is null)
        {
            return PersonaErrors.NotFoundPersona;
        }
        
        return personaResult.Value;
    }
}