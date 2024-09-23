using System.ComponentModel;

namespace Domain.Models;

public class Dte
{
    public string Id { get; set; } = null!;
    public string? tipoDte { get; set; }

    public bool IsTipoDteAllew(string tipoDte)
    {
        // verify
        return true;
    }
}