using System;
using System.Collections.Generic;

#nullable disable

namespace App.TallerMoto.Dominio.Entidades
{
    public partial class Repuesto
    {
        public Repuesto()
        {
            DetalleXrepuestos = new HashSet<DetalleXrepuesto>();
        }

        public long IdRepuesto { get; set; }
        public string Nombre { get; set; }
        public int? Cantidad { get; set; }
        public string Referencia { get; set; }
        public long? IdCategoria { get; set; }

        public virtual Categorium IdCategoriaNavigation { get; set; }
        public virtual ICollection<DetalleXrepuesto> DetalleXrepuestos { get; set; }
    }
}
