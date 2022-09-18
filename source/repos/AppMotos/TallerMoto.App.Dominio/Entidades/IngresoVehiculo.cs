using System;
using System.Collections.Generic;
using System.Text;

namespace TallerMoto.App.Dominio.Entidades
{
    public class IngresoVehiculo : Persona
    {
        public int IdIngreso { get; set; }
        public Persona IdUsuario { get; set; }
        public Persona IdRecepcionista { get; set; }
        public Persona IdMecanico { get; set; }
        public string TipoVehiculo { get; set; }
        public string Descripcion { get; set; }
        public string Placa { get; set; }
        public DateTime FechaIngreso { get; set; }





    }
}