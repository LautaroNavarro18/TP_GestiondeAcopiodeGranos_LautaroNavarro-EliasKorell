using AccesoDatos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos
{
    public class AcopioContext : DbContext
    {
        public DbSet<Productor> Productores { get; set; }
        public DbSet<Cereal> Cereales { get; set; }
        public DbSet<Descarga> Descargas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Despacho> Despachos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string rutaBase = Path.Combine(AppContext.BaseDirectory, "acopio.db");
            optionsBuilder.UseSqlite($"Data Source={rutaBase}");
        }
    }
}
