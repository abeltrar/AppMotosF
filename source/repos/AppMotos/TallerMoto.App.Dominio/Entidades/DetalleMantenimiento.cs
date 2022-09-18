using System;
using System.Collections.Generic;
using System.Text;


namespace TallerMoto.App.Dominio.Entidades
{
    public class DetalleMantenimiento
    {

        public Estado estado { get; set; }
        public int IdDetalle { get; set; }
        public IngresoVehiculo IdIngreso { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Observacion { get; set; }



    }
}
