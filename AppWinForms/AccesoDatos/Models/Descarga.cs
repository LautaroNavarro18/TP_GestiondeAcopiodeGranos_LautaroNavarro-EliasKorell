using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos.Models
{
    public enum EstadoDescarga { Aceptada, Rechazada }

    public class Descarga
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public int ProductorId { get; set; }
        public Productor Productor { get; set; }

        public int CerealId { get; set; }
        public Cereal Cereal { get; set; }

        public string Patente { get; set; }
        public int KilosBrutos { get; set; }
        public int Tara { get; set; }
        public double Humedad { get; set; }
        public EstadoDescarga Estado { get; set; }

        public int KilosNetos()
        {
            return KilosBrutos - Tara;
        }

        public void DeterminarEstado(double humedadMaxima)
        {
            if (Humedad <= humedadMaxima)
                Estado = EstadoDescarga.Aceptada;
            else
                Estado = EstadoDescarga.Rechazada;
        }
    }
}