
using System.ComponentModel.DataAnnotations;

namespace LojaApp.Data;
public class Produto
{
    public int Id { get; set; }

    public Categoria? Categoria { get; set; }
    public int? CategoriaId { get; set; }

    [StringLength(255)]
    public string? Nome { get; set; }

    [Required]
    public int Quantidade { get; set; }

    [Required]
    public decimal Valor { get; set; }
}
