using AutoMapper;
using Domain.Models;
using Domain.Ports.Driven;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Adapters.Driven.Database.Repositories;

public class PersonaRepository(PruebaConceptoContext context, IMapper mapper) : BaseRepository<Persona>(context), IPersonaRepository
{
    private readonly PruebaConceptoContext _context = context;

    public async Task<Persona?> GetPersonaById(int id)
    {
        var persona = await _context.Personas.SingleOrDefaultAsync(p => p != null && p.Id == id);
        
        return persona != null ? mapper.Map<Persona>(persona) : null;
    }
}
