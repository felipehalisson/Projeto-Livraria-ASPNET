using Microsoft.EntityFrameworkCore;
using ProjetoLivraria.Models;

namespace ProjetoLivraria.Data
{
    public class LivrariaContext(DbContextOptions<LivrariaContext> options) : DbContext(options)
    {
        public DbSet<Login> Logins => Set<Login>();
        public DbSet<Livro> Livros => Set<Livro>();
    }
}