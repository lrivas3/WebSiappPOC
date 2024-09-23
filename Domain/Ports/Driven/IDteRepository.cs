using Domain.Models;

namespace Domain.Ports.Driven;

public interface IDteRepository
{
    Task<string> RegisterDte(Dte dte);
}