using System;
using System.Collections.Generic;
using System.Text;
using App.TallerMoto.Dominio.Entidades;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public interface IDetalleXRepuesto
    {
        int add(DetalleXrepuesto detalleXRepuesto);
        DetalleXrepuesto Find(int id);

        int ActualizarDetalleXRepuesto(DetalleXrepuesto detallexrepuesto);
        int EliminarDetalleXRepuesto(DetalleXrepuesto detalleXRepuesto);
    }
}