
using Microsoft.EntityFrameworkCore;

namespace LojaApp.Data;
public class LojaContext : DbContext
{
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Categoria> Categorias { get; set; }

    public LojaContext(DbContextOptions<LojaContext> options) : base(options)
    {

    }
}
