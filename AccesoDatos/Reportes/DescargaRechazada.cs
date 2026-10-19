using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos.Reportes
{
    public class DescargaRechazada
    {
        public DateTime Fecha { get; set; }
        public string Productor { get; set; }
        public string Cereal { get; set; }
        public string Patente { get; set; }
        public int KilosNetos { get; set; }
        public double Humedad { get; set; }
        public double HumedadMaxima { get; set; }
    }
}
