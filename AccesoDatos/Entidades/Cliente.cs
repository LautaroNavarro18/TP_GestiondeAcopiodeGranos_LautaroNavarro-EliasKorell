using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public string Telefono { get; set; }
        public string Localidad { get; set; }
        public bool Activo { get; set; } = true;

        public List<Despacho> Despachos { get; set; } = new List<Despacho>();
    }
}