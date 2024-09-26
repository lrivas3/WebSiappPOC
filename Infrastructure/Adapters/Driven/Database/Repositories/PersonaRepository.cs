using AutoMapper;
using Domain.Models;
using Domain.Ports.Driven;
using Infrastructure.Adapters.Driven.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Adapters.Driven.Database.Repositories;

public class PersonaRepository(PruebaConceptoContext context, IMapper mapper) : BaseRepository<PersonaEntity>(context), IPersonaRepository
{
    private readonly PruebaConceptoContext _context = context;

    public async Task<PersonaModel?> GetPersonaById(int id)
    {
        var persona = await _context.Personas.SingleOrDefaultAsync(p => p != null && p.Id == id);
        
        return persona != null ? mapper.Map<PersonaModel>(persona) : null;
    }
    
    public async Task<PersonaModel?> AddPersona(PersonaModel persona)
    {
        var personaEntity = mapper.Map<PersonaEntity>(persona);
        
        await _context.Personas.AddAsync(personaEntity);
        await _context.SaveChangesAsync();
        
        var personaSavedResult = mapper.Map<PersonaModel>(personaEntity);

        return personaSavedResult;
    }
}
