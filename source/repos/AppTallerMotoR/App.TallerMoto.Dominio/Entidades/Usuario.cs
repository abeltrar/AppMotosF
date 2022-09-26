using System;
using System.Collections.Generic;

#nullable disable

namespace App.TallerMoto.Dominio.Entidades
{
    public partial class Usuario
    {
        public long IdUsuario { get; set; }
        public long? IdPersona { get; set; }
        public string Usuario1 { get; set; }
        public string Contraseña { get; set; }

        public virtual Persona IdPersonaNavigation { get; set; }
    }
}
