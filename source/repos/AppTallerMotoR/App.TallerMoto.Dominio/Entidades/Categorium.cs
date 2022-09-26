using System;
using System.Collections.Generic;

#nullable disable

namespace App.TallerMoto.Dominio.Entidades
{
    public partial class Categorium
    {
        public Categorium()
        {
            Repuestos = new HashSet<Repuesto>();
        }

        public long IdCategoria { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Repuesto> Repuestos { get; set; }
    }
}
