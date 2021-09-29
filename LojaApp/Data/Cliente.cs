
using System.ComponentModel.DataAnnotations;

namespace LojaApp.Data;
public class Cliente
{
    public int id { get; set; }

    [StringLength(255)]
    public string? nome { get; set; }

    public string? Cpf { get; set; }

    [Required]
    public string? telefone { get; set; }

    [Required]
    public string? email { get; set; }
    
    [Required]
    public string? sexo { get; set; } 
    
    [Required]
    public string? estadoCivil { get; set; }
    
    public string? escolaridade { get; set; }
    
    public string? dataNascimento { get; set; }

    [StringLength(1000)]
    public string? Endereço { get; set; }
}
