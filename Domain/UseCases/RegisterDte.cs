using Domain.Models;
using Domain.Ports.Driven;
using Domain.Ports.Driving;

namespace Domain.UseCases;

public class RegisterDte : IRegisterDte
{
    private readonly IDteRepository _dteRepository;

    public RegisterDte(IDteRepository dteRepository)
    {
        _dteRepository = dteRepository;
    }

    public async Task<string> Execute(string tipoDte)
    {
        var dte = new Dte()
        {
            tipoDte = tipoDte,
        };
        var createdDteId = await _dteRepository.RegisterDte(dte);
        
        return createdDteId;
    }
}