using AccesoDatos.Entidades;
using AccesoDatos.Reportes;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos.Repositorios
{
    public class ReporteRepositorio : IReporteRepositorio
    {
        public List<ProductorKilos> RankingProductores()
        {
            using var context = new AcopioContext();
            List<ProductorKilos> ranking = context.Productores
                .Include(p => p.Descargas)
                .ToList()
                .Select(p => new ProductorKilos
                {
                    Productor = p.Nombre,
                    Descargas = p.Descargas.Count(d => d.Estado == EstadoDescarga.Aceptada),
                    KilosNetos = p.Descargas
                        .Where(d => d.Estado == EstadoDescarga.Aceptada)
                        .Sum(d => d.KilosNetos())
                })
                .Where(r => r.KilosNetos > 0)
                .OrderByDescending(r => r.KilosNetos)
                .ToList();

            for (int i = 0; i < ranking.Count; i++)
                ranking[i].Puesto = i + 1;

            return ranking;
        }

        public List<CerealKilos> KilosRecibidosPorCereal()
        {
            using var context = new AcopioContext();
            return context.Cereales
                .Include(c => c.Descargas)
                .ToList()
                .Select(c => new CerealKilos
                {
                    Cereal = c.Nombre,
                    Descargas = c.Descargas.Count(d => d.Estado == EstadoDescarga.Aceptada),
                    KilosNetos = c.Descargas
                        .Where(d => d.Estado == EstadoDescarga.Aceptada)
                        .Sum(d => d.KilosNetos())
                })
                .Where(r => r.Descargas > 0)
                .OrderByDescending(r => r.KilosNetos)
                .ToList();
        }

        public List<DescargasMes> DescargasPorMes()
        {
            using var context = new AcopioContext();
            return context.Descargas
                .ToList()
                .GroupBy(d => new { d.Fecha.Year, d.Fecha.Month })
                .OrderBy(g => g.Key.Year)
                .ThenBy(g => g.Key.Month)
                .Select(g => new DescargasMes
                {
                    Mes = $"{g.Key.Month:00}/{g.Key.Year}",
                    Cantidad = g.Count(),
                    KilosNetos = g
                        .Where(d => d.Estado == EstadoDescarga.Aceptada)
                        .Sum(d => d.KilosNetos())
                })
                .ToList();
        }

        public List<DescargaRechazada> DescargasRechazadas()
        {
            using var context = new AcopioContext();
            return context.Descargas
                .Include(d => d.Productor)
                .Include(d => d.Cereal)
                .Where(d => d.Estado == EstadoDescarga.Rechazada)
                .OrderByDescending(d => d.Fecha)
                .ToList()
                .Select(d => new DescargaRechazada
                {
                    Fecha = d.Fecha,
                    Productor = d.Productor.Nombre,
                    Cereal = d.Cereal.Nombre,
                    Patente = d.Patente,
                    KilosNetos = d.KilosNetos(),
                    Humedad = d.Humedad,
                    HumedadMaxima = d.Cereal.HumedadMaxima
                })
                .ToList();
        }

        public List<HistorialDescarga> HistorialProductor(int productorId)
        {
            using var context = new AcopioContext();
            return context.Descargas
                .Include(d => d.Cereal)
                .Where(d => d.ProductorId == productorId)
                .OrderByDescending(d => d.Fecha)
                .ToList()
                .Select(d => new HistorialDescarga
                {
                    Fecha = d.Fecha,
                    Cereal = d.Cereal.Nombre,
                    Patente = d.Patente,
                    KilosNetos = d.KilosNetos(),
                    Humedad = d.Humedad,
                    HumedadMaxima = d.Cereal.HumedadMaxima,
                    Estado = d.Estado.ToString()
                })
                .ToList();
        }

        public List<ClienteKilos> KilosDespachadosPorCliente()
        {
            using var context = new AcopioContext();
            return context.Clientes
                .Include(c => c.Despachos)
                .ToList()
                .Select(c => new ClienteKilos
                {
                    Cliente = c.Nombre,
                    Despachos = c.Despachos.Count,
                    KilosNetos = c.Despachos.Sum(d => d.KilosNetos())
                })
                .Where(r => r.Despachos > 0)
                .OrderByDescending(r => r.KilosNetos)
                .ToList();
        }

        public List<DespachoRealizado> DespachosRealizados()
        {
            using var context = new AcopioContext();
            return context.Despachos
                .Include(d => d.Cliente)
                .Include(d => d.Cereal)
                .OrderByDescending(d => d.Fecha)
                .ToList()
                .Select(d => new DespachoRealizado
                {
                    Fecha = d.Fecha,
                    Cliente = d.Cliente.Nombre,
                    Cereal = d.Cereal.Nombre,
                    Patente = d.Patente,
                    KilosNetos = d.KilosNetos()
                })
                .ToList();
        }
    }
}