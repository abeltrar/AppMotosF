using System;
using System.Collections.Generic;
using System.Text;

namespace TallerMoto.App.Dominio.Entidades
{
    public class DetalleXRepuesto
    {
        public int IdDetalleXRepuestos { get; set; }
        public DetalleMantenimiento IdDetalle { get; set; }
        public Repuestos IdRepuesto { get; set; }
        public string Placa { get; set; }
        public int Cantidad { get; set; }


    }
}