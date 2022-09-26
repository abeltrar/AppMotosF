using System;
using System.Collections.Generic;

#nullable disable

namespace App.TallerMoto.Dominio.Entidades
{
    public partial class DetalleMantenimiento
    {
        public DetalleMantenimiento()
        {
            DetalleXrepuestos = new HashSet<DetalleXrepuesto>();
        }

        public long IdDetalle { get; set; }
        public long? IdIngreso { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }

        public virtual IngresoVehiculo IdIngresoNavigation { get; set; }
        public virtual ICollection<DetalleXrepuesto> DetalleXrepuestos { get; set; }
    }
}
