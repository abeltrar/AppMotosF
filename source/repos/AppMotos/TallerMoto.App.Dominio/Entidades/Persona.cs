using System;
using System.Collections.Generic;
using System.Text;


namespace TallerMoto.App.Dominio.Entidades
{
    public class Persona
    {
        public int IdPersona { get; set; }

        public string Nombre { get; set; }
        public int Cedula { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public Rol IdRol { get; set; }






    }
}
