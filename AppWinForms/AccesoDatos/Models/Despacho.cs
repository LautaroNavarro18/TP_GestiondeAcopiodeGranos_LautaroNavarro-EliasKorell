using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos.Models
{
    public class Despacho
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int CerealId { get; set; }
        public Cereal Cereal { get; set; }

        public string Patente { get; set; }
        public int KilosBrutos { get; set; }
        public int Tara { get; set; }

        public int KilosNetos()
        {
            return KilosBrutos - Tara;
        }
    }
}
