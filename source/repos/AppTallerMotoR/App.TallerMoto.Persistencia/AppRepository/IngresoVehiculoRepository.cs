using System;
using System.Collections.Generic;
using System.Text;
using App.TallerMoto.Dominio.Entidades;
using App.TallerMoto.Persistencia.AppRepository;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public class IngresoVehiculoRepository : IIngresoVehiculo
    {
        private readonly Context _context;
        public IngresoVehiculoRepository(Context context)
        {
            _context = context;
        }


        public int add(IngresoVehiculo ingresoVehiculo)
        {
            _context.IngresoVehiculos.Add(ingresoVehiculo);
            return _context.SaveChanges();
        }

        IngresoVehiculo IIngresoVehiculo.Find(int id)
        {
            return _context.IngresoVehiculos.Find(id);
        }

        public int ActualizarIngresoVehiculo(IngresoVehiculo ingresovehiculo)
        {
            _context.IngresoVehiculos.Update(ingresovehiculo);
            return _context.SaveChanges();

        }

        public int EliminarIngresoVehiculo(IngresoVehiculo ingresoVehiculo)
        {
            _context.IngresoVehiculos.Remove(ingresoVehiculo);
            return _context.SaveChanges();

        }
    }
}
