using System;
using System.Collections.Generic;

#nullable disable

namespace App.TallerMoto.Dominio.Entidades
{
    public partial class IngresoVehiculo
    {
        public IngresoVehiculo()
        {
            DetalleMantenimientos = new HashSet<DetalleMantenimiento>();
        }

        public long IdIngreso { get; set; }
        public string Placa { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public long? IdRecepcionista { get; set; }
        public long? IdUsuario { get; set; }
        public long? IdMecanico { get; set; }
        public string TipoVehiculo { get; set; }
        public string Descripicion { get; set; }

        public virtual Persona IdMecanicoNavigation { get; set; }
        public virtual Persona IdRecepcionistaNavigation { get; set; }
        public virtual Persona IdUsuarioNavigation { get; set; }
        public virtual ICollection<DetalleMantenimiento> DetalleMantenimientos { get; set; }
    }
}
