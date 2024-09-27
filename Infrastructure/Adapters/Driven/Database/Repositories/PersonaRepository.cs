using AutoMapper;
using Domain.Models;
using Domain.Ports.Driven;
using ErrorOr;
using Infrastructure.Adapters.Driven.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Adapters.Driven.Database.Repositories;

public class PersonaRepository(PruebaConceptoContext context, IMapper mapper) : BaseRepository<PersonaEntity>(context), IPersonaRepository
{
    private readonly PruebaConceptoContext _context = context;

    public async Task<ErrorOr<PersonaModel?>> GetPersonaById(int id)
    {
        PersonaEntity? persona = await _context.Personas.SingleOrDefaultAsync(p => p != null && p.Id == id);

        if (persona == null)
        {
            return Error.NotFound($"No se encontro a la persona con id: {id}");
        }
        
        return mapper.Map<PersonaModel>(persona);
    }

    public async Task<ErrorOr<PersonaModel?>> AddPersona(PersonaModel persona)
    {
        var personaEntity = mapper.Map<PersonaEntity>(persona);
        
        await _context.Personas.AddAsync(personaEntity);
        await _context.SaveChangesAsync();
        
        var personaSavedResult = mapper.Map<PersonaModel>(personaEntity);

        return personaSavedResult;
    }
}
