using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class Context(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:finadmin.database.windows.net,1433;Initial Catalog=dev-finadmin;Persist Security Info=False;User ID=mila;Password=5414@Arcana;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
