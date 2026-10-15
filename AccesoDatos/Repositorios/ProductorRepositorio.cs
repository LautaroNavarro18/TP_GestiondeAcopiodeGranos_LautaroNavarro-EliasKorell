using AccesoDatos.Entidades;

namespace AccesoDatos.Repositorios
{
    public class ProductorRepositorio : IProductorRepositorio
    {
        public void Agregar(Productor productor)
        {
            using var context = new AcopioContext();
            context.Productores
                .Add(productor);
            context
                .SaveChanges();
        }

        public void Modificar(Productor productor)
        {
            using var context = new AcopioContext();
            context.Productores
                .Update(productor);
            context
                .SaveChanges();
        }

        public void Eliminar(int id)
        {
            using var context = new AcopioContext();
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
            using var context = new AcopioContext();
            return context.Productores
                .Find(id);
        }

        public List<Productor> ObtenerTodos()
        {
            using var context = new AcopioContext();
            return context.Productores
                .Where(p => p.Activo)
                .ToList();
        }
    }
}
