using AccesoDatos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos.Repositorios
{
    public class DespachoRepositorio : IDespachoRepositorio
    {
        public void Agregar(Despacho despacho)
        {
            using var context = new AcopioContext();
            int stock = CalculoStock
                .StockDisponible(context, despacho.CerealId);

            if (despacho.KilosNetos() > stock)
                throw new InvalidOperationException("No hay stock suficiente del cereal seleccionado para registrar el despacho.");

            context.Despachos
                .Add(despacho);
            context
                .SaveChanges();
        }

        public void Modificar(Despacho despacho)
        {
            using var context = new AcopioContext();
            Despacho original = context.Despachos
                .AsNoTracking()
                .FirstOrDefault(d => d.Id == despacho.Id);

            int stock = CalculoStock
                .StockDisponible(context, despacho.CerealId);

            if (original.CerealId == despacho.CerealId)
                stock += original.KilosNetos();

            if (despacho.KilosNetos() > stock)
                throw new InvalidOperationException("No hay stock suficiente del cereal seleccionado para modificar el despacho.");

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
