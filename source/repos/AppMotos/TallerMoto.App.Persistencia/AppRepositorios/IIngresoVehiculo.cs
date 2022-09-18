using System;
using System.Collections.Generic;
using System.Text;
using TallerMoto.App.Dominio.Entidades;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public interface IIngresoVehiculo
    {
        int add(IngresoVehiculo ingresoVehiculo);
        IngresoVehiculo Find(int id);
        int ActualizarIngresoVehiculo(IngresoVehiculo ingresovehiculo);
        int EliminarIngresoVehiculo(IngresoVehiculo ingresoVehiculo);

    }
}