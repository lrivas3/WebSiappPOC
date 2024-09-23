using Domain.Models;
using Domain.Ports.Driven;
using Infrastructure.Adapters.Driven.Database.Models;

namespace Infrastructure.Adapters.Driven.Database.Repositories;

// Generalmente deberiamos hacer que este repo implemente un base repo para consistencia
public class DteRepository : IDteRepository
{
    private readonly FacturacionContext _context;

    public DteRepository(FacturacionContext context)
    {
        _context = context;
    }

    public Task<string> RegisterDte(Dte dte)
    {
        // conver to database model, map it with automapper maybe
        if (dte.tipoDte is null)
        {
            throw new NotImplementedException();
        }
        var newDte = new DteEntity
        {
            Id = "21321",
            tipoDte = dte.tipoDte
        };
        _context.Dtes.Add(newDte);
        
        return Task.FromResult(newDte.Id);
    }
}