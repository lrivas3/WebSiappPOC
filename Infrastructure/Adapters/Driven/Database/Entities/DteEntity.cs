using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Adapters.Driven.Database.Models;

public class DteEntity
{
    [Key]
    public string Id { get; set; } = null!;

    [Required] [StringLength(2)] public string tipoDte { get; set; } = null!;
}