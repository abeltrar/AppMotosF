using System;
using System.Collections.Generic;

#nullable disable

namespace App.TallerMoto.Dominio.Entidades
{
    public partial class DetalleXrepuesto
    {
        public long IdDetalleXrepuesto { get; set; }
        public long? IdDetalle { get; set; }
        public long? IdRepuesto { get; set; }
        public string Placa { get; set; }
        public int? Cantidad { get; set; }

        public virtual DetalleMantenimiento IdDetalleNavigation { get; set; }
        public virtual Repuesto IdRepuestoNavigation { get; set; }
    }
}
