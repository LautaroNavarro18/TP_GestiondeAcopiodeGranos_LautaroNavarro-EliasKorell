using System;
using System.Collections.Generic;
using System.Text;
using AccesoDatos.Reportes;

namespace AccesoDatos.Repositorios
{
    public interface IReporteRepositorio
    {

        List<ProductorKilos> RankingProductores();
        List<CerealKilos> KilosRecibidosPorCereal();
        List<DescargasMes> DescargasPorMes();
        List<DescargaRechazada> DescargasRechazadas();
        List<HistorialDescarga> HistorialProductor(int productorId);
        List<ClienteKilos> KilosDespachadosPorCliente();
        List<StockCereal> StockPorCereal();
    }

}

