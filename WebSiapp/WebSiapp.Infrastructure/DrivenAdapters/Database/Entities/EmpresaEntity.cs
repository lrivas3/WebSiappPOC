﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSiapp.Infrastructure.DrivenAdapters.Database.Entities;

[Table("Empresa", Schema = "PRUEBA")]
public class EmpresaEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required] [StringLength(200)] public string Nombre { get; set; }

    [StringLength(50)] public string Telefono { get; set; }

    [StringLength(200)] public string Direccion { get; set; }
}