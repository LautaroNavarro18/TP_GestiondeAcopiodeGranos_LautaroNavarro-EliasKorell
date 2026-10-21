using AccesoDatos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos.Repositorios
{
    public class DescargaRepositorio : IDescargaRepositorio
    {
        public void Agregar(Descarga descarga)
        {
            using var context = new AcopioContext();
            Cereal cereal = context.Cereales
                .Find(descarga.CerealId);
            descarga
                .DeterminarEstado(cereal.HumedadMaxima);
            context.Descargas
                .Add(descarga);
            context
                .SaveChanges();
        }

        public void Modificar(Descarga descarga)
        {
            using var context = new AcopioContext();
            Descarga original = context.Descargas
                .AsNoTracking()
                .FirstOrDefault(d => d.Id == descarga.Id);

            Cereal cereal = context.Cereales
                .Find(descarga.CerealId);
            descarga
                .DeterminarEstado(cereal.HumedadMaxima);

            ValidarStockModificacion(context, original, descarga);

            context.Descargas
                .Update(descarga);
            context
                .SaveChanges();
        }

        public void Eliminar(int id)
        {
            using var context = new AcopioContext();
            Descarga descarga = context.Descargas
                .Find(id);
            if (descarga != null)
            {
                if (descarga.Estado == EstadoDescarga.Aceptada)
                {
                    int stockSinDescarga = CalculoStock
                        .StockDisponible(context, descarga.CerealId) - descarga.KilosNetos();

                    if (stockSinDescarga < 0)
                        throw new InvalidOperationException("No se puede eliminar la descarga porque el cereal ya fue despachado y el stock quedaría negativo.");
                }

                context.Descargas
                    .Remove(descarga);
                context
                    .SaveChanges();
            }
        }

        private void ValidarStockModificacion(AcopioContext context, Descarga original, Descarga nueva)
        {
            if (original.CerealId == nueva.CerealId)
            {
                int stockSinOriginal = CalculoStock.StockDisponible(context, nueva.CerealId)
                    - (original.Estado == EstadoDescarga.Aceptada ? original.KilosNetos() : 0);
                int stockConNueva = stockSinOriginal
                    + (nueva.Estado == EstadoDescarga.Aceptada ? nueva.KilosNetos() : 0);

                if (stockConNueva < 0)
                    throw new InvalidOperationException("No se puede modificar la descarga porque el cereal ya fue despachado y el stock quedaría negativo.");
            }
            else
            {
                int stockCerealOriginal = CalculoStock.StockDisponible(context, original.CerealId)
                    - (original.Estado == EstadoDescarga.Aceptada ? original.KilosNetos() : 0);

                if (stockCerealOriginal < 0)
                    throw new InvalidOperationException("No se puede modificar la descarga porque el cereal ya fue despachado y el stock quedaría negativo.");
            }
        }

        public Descarga ObtenerPorId(int id)
        {
            using var context = new AcopioContext();
            return context.Descargas
                .Include(d => d.Productor)
                .Include(d => d.Cereal)
                .FirstOrDefault(d => d.Id == id);
        }

        public List<Descarga> ObtenerTodos()
        {
            using var context = new AcopioContext();
            return context.Descargas
                .Include(d => d.Productor)
                .Include(d => d.Cereal)
                .ToList();
        }
    }
}
