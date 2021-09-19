
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LojaApp.Data;
public class Categoria
{
    public int Id { get; set; }

    [StringLength(255)]
    public string? Descricao { get; set; }

    public List<Produto>? Produtos { get; set; }
}
