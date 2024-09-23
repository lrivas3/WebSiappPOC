namespace Domain.Ports.Driving;

public interface IRegisterDte
{
    Task<string> Execute(string tipoDte);
}