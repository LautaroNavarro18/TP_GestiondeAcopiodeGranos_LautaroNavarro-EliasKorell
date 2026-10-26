using AccesoDatos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos
{
    public class AcopioContext : DbContext
    {
        public static string CadenaConexion => $"Data Source={Path.Combine(AppContext.BaseDirectory, "acopio.db")}";

        public DbSet<Productor> Productores { get; set; }
        public DbSet<Cereal> Cereales { get; set; }
        public DbSet<Descarga> Descargas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Despacho> Despachos { get; set; }

        public AcopioContext(DbContextOptions<AcopioContext> options) : base(options)
        {
        }
    }
}
