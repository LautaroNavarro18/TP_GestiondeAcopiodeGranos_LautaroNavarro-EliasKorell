using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos.Entidades
{
    public class Cereal
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double HumedadMaxima { get; set; }
        public bool Activo { get; set; } = true;

        public List<Descarga> Descargas { get; set; } = new List<Descarga>();
        public List<Despacho> Despachos { get; set; } = new List<Despacho>();

        public int StockDisponible()
        {
            int recibido = Descargas
                .Where(d => d.Estado == EstadoDescarga.Aceptada)
                .Sum(d => d.KilosNetos());

            int despachado = Despachos.Sum(d => d.KilosNetos());

            return recibido - despachado;
        }
    }
}
