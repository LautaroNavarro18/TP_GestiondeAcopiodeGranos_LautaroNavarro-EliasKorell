using AccesoDatos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos.Repositorios
{
    public class DespachoRepositorio : IDespachoRepositorio
    {
        public void Agregar(Despacho despacho)
        {
            using var context = new AcopioContext();
            context.Despachos
                .Add(despacho);
            context
                .SaveChanges();
        }

        public void Modificar(Despacho despacho)
        {
            using var context = new AcopioContext();
            context.Despachos
                .Update(despacho);
            context
                .SaveChanges();
        }

        public void Eliminar(int id)
        {
            using var context = new AcopioContext();
            Despacho despacho = context.Despachos
                .Find(id);
            if (despacho != null)
            {
                context.Despachos
                    .Remove(despacho);
                context
                    .SaveChanges();
            }
        }

        public Despacho ObtenerPorId(int id)
        {
            using var context = new AcopioContext();
            return context.Despachos
                .Include(d => d.Cliente)
                .Include(d => d.Cereal)
                .FirstOrDefault(d => d.Id == id);
        }

        public List<Despacho> ObtenerTodos()
        {
            using var context = new AcopioContext();
            return context.Despachos
                .Include(d => d.Cliente)
                .Include(d => d.Cereal)
                .ToList();
        }
    }
}
