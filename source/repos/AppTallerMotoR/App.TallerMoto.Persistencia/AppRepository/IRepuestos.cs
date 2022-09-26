using System;
using System.Collections.Generic;
using System.Text;
using App.TallerMoto.Dominio.Entidades;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public interface IRepuestos
    {
        int Add(Repuesto repuestos);
        Repuesto Find(int id);
        int ActualizarRepuesto(Repuesto repuesto);
        int EliminarRepuesto(Repuesto repuestos);

    }
}
