using System;
using System.Collections.Generic;
using System.Text;
using TallerMoto.App.Dominio.Entidades;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public interface IRepuestos
    {
        int Add(Repuestos repuestos);
        Repuestos Find(int id);
        int ActualizarRepuesto(Repuestos repuesto);
        int EliminarRepuesto(Repuestos repuestos);

    }
}
