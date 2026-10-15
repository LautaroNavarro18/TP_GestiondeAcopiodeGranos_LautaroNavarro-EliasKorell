using AccesoDatos.Entidades;

namespace AccesoDatos.Repositorios
{
    public class CerealRepositorio : ICerealRepositorio
    {
        public void Agregar(Cereal cereal)
        {
            using var context = new AcopioContext();
            context.Cereales
                .Add(cereal);
            context
                .SaveChanges();
        }

        public void Modificar(Cereal cereal)
        {
            using var context = new AcopioContext();
            context.Cereales
                .Update(cereal);
            context
                .SaveChanges();
        }

        public void Eliminar(int id)
        {
            using var context = new AcopioContext();
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
            using var context = new AcopioContext();
            return context.Cereales
                .Find(id);
        }

        public List<Cereal> ObtenerTodos()
        {
            using var context = new AcopioContext();
            return context.Cereales
                .Where(c => c.Activo)
                .ToList();
        }
    }
}
