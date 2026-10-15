using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos.Entidades
{
    public class Productor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public string Telefono { get; set; }
        public string Localidad { get; set; }
        public bool Activo { get; set; } = true;

        public List<Descarga> Descargas { get; set; } = new List<Descarga>();
    }
}