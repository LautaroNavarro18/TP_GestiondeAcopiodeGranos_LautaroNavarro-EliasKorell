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
            Cereal cereal = context.Cereales
                .Find(descarga.CerealId);
            descarga
                .DeterminarEstado(cereal.HumedadMaxima);
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
                context.Descargas
                    .Remove(descarga);
                context
                    .SaveChanges();
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
