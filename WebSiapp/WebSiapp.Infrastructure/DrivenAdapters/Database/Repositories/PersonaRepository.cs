using AutoMapper;
using WebSiapp.Domain.Models;
using WebSiapp.Domain.Ports.Driven;
using Microsoft.EntityFrameworkCore;
using WebSiapp.Infrastructure.DrivenAdapters.Database.Entities;

namespace WebSiapp.Infrastructure.DrivenAdapters.Database.Repositories;

public class PersonaRepository(PruebaConceptoContext context, IMapper mapper) : BaseRepository<PersonaEntity>(context), IPersonaRepository
{
    private readonly PruebaConceptoContext _context = context;

    public async Task<PersonaModel?> GetPersonaById(int id)
    {
        PersonaEntity? persona = await _context.Personas.SingleOrDefaultAsync(p => p != null && p.Id == id);

        return persona is null ? null : mapper.Map<PersonaModel>(persona);
    }

    public async Task<PersonaModel?> AddPersona(PersonaModel persona)
    {
        var personaEntity = mapper.Map<PersonaEntity>(persona);
        
        await _context.Personas.AddAsync(personaEntity);
        await _context.SaveChangesAsync();
        
        var personaSavedResult = mapper.Map<PersonaModel>(personaEntity);

        return personaSavedResult;
    }

    public async Task<PersonaModel?> FindByEmail(string personaModelEmail)
    {
        PersonaEntity? persona =
            await _context.Personas.SingleOrDefaultAsync(p => p != null && p.Email == personaModelEmail);

        return persona is null ? null : mapper.Map<PersonaModel>(persona);
    }
}
