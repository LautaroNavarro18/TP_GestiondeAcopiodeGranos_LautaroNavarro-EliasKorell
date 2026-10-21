using AccesoDatos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos.Repositorios
{
    public static class CalculoStock
    {
        public static int StockDisponible(AcopioContext context, int cerealId)
        {
            Cereal cereal = context.Cereales
                .Include(c => c.Descargas)
                .Include(c => c.Despachos)
                .FirstOrDefault(c => c.Id == cerealId);

            return cereal.StockDisponible();
        }
    }
}
