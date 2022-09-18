using System;
using System.Collections.Generic;
using System.Text;

namespace TallerMoto.App.Dominio.Entidades
{
    public class Repuestos
    {
        public int IdRepuesto { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string Referencia { get; set; }
        public Categoria Idcategoria { get; set; }

    }
}
