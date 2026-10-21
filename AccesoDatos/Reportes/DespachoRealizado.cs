using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos.Reportes
{
    public class DespachoRealizado
    {
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Cereal { get; set; }
        public string Patente { get; set; }
        public int KilosNetos { get; set; }
    }
}
