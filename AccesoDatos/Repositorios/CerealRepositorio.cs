using AccesoDatos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos.Repositorios
{
    public class CerealRepositorio : ICerealRepositorio
    {
        private readonly IDbContextFactory<AcopioContext> _contextFactory;

        public CerealRepositorio(IDbContextFactory<AcopioContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public void Agregar(Cereal cereal)
        {
            using var context = _contextFactory
                .CreateDbContext();
            context.Cereales
                .Add(cereal);
            context
                .SaveChanges();
        }

        public void Modificar(Cereal cereal)
        {
            using var context = _contextFactory
                .CreateDbContext();
            context.Cereales
                .Update(cereal);
            context
                .SaveChanges();
        }

        public void Eliminar(int id)
        {
            using var context = _contextFactory
                .CreateDbContext();
            Cereal cereal = context.Cereales
                .Find(id);
            if (cereal != null)
            {
                cereal.Activo = false;
                context
                    .SaveChanges();
            }
        }

        public Cereal ObtenerPorId(int id)
        {
            using var context = _contextFactory
                .CreateDbContext();
            return context.Cereales
                .Find(id);
        }

        public List<Cereal> ObtenerTodos()
        {
            using var context = _contextFactory
                .CreateDbContext();
            return context.Cereales
                .Where(c => c.Activo)
                .ToList();
        }

        public int StockDisponible(int cerealId)
        {
            using var context = _contextFactory
                .CreateDbContext();
            return CalculoStock
                .StockDisponible(context, cerealId);
        }
    }
}
