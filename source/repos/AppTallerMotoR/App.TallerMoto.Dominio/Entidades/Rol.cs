using System;
using System.Collections.Generic;

#nullable disable

namespace App.TallerMoto.Dominio.Entidades
{
    public partial class Rol
    {
        public Rol()
        {
            Personas = new HashSet<Persona>();
        }

        public long IdRol { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
