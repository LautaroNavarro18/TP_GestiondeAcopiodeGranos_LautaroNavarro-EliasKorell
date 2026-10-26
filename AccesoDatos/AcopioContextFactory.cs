using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AccesoDatos
{
    public class AcopioContextFactory : IDesignTimeDbContextFactory<AcopioContext>
    {
        public AcopioContext CreateDbContext(string[] args)
        {
            DbContextOptions<AcopioContext> options = new DbContextOptionsBuilder<AcopioContext>()
                .UseSqlite(AcopioContext.CadenaConexion)
                .Options;

            return new AcopioContext(options);
        }
    }
}
