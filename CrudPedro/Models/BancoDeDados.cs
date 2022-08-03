using Microsoft.EntityFrameworkCore;

namespace CrudPedro.Models
{
    public class BancoDeDados: DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=CrudPedro;Integrated Security=True");
        }
    }
}
