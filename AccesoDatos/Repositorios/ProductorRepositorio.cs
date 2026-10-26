using AccesoDatos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos.Repositorios
{
    public class ProductorRepositorio : IProductorRepositorio
    {
        private readonly IDbContextFactory<AcopioContext> _contextFactory;

        public ProductorRepositorio(IDbContextFactory<AcopioContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public void Agregar(Productor productor)
        {
            using var context = _contextFactory
                .CreateDbContext();
            context.Productores
                .Add(productor);
            context
                .SaveChanges();
        }

        public void Modificar(Productor productor)
        {
            using var context = _contextFactory
                .CreateDbContext();
            context.Productores
                .Update(productor);
            context
                .SaveChanges();
        }

        public void Eliminar(int id)
        {
            using var context = _contextFactory
                .CreateDbContext();
            Productor productor = context.Productores
                .Find(id);
            if (productor != null)
            {
                productor.Activo = false;
                context
                    .SaveChanges();
            }
        }

        public Productor ObtenerPorId(int id)
        {
            using var context = _contextFactory
                .CreateDbContext();
            return context.Productores
                .Find(id);
        }

        public List<Productor> ObtenerTodos()
        {
            using var context = _contextFactory
                .CreateDbContext();
            return context.Productores
                .Where(p => p.Activo)
                .ToList();
        }
    }
}
