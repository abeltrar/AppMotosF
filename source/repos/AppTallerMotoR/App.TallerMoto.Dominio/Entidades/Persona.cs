using System;
using System.Collections.Generic;

#nullable disable

namespace App.TallerMoto.Dominio.Entidades
{
    public partial class Persona
    {
        public Persona()
        {
            IngresoVehiculoIdMecanicoNavigations = new HashSet<IngresoVehiculo>();
            IngresoVehiculoIdRecepcionistaNavigations = new HashSet<IngresoVehiculo>();
            IngresoVehiculoIdUsuarioNavigations = new HashSet<IngresoVehiculo>();
            Usuarios = new HashSet<Usuario>();
        }

        public long IdPersona { get; set; }
        public string Nombre { get; set; }
        public long? Cedula { get; set; }
        public long? Telefono { get; set; }
        public string Direccion { get; set; }
        public long? IdRol { get; set; }

        public virtual Rol IdRolNavigation { get; set; }
        public virtual ICollection<IngresoVehiculo> IngresoVehiculoIdMecanicoNavigations { get; set; }
        public virtual ICollection<IngresoVehiculo> IngresoVehiculoIdRecepcionistaNavigations { get; set; }
        public virtual ICollection<IngresoVehiculo> IngresoVehiculoIdUsuarioNavigations { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
