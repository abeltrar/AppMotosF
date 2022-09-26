using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App.TallerMoto.Dominio.Entidades;
using App.TallerMoto.Persistencia.AppRepository;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public class DetalleMantenimientoRepository : IDetalleMantenimiento
    {
        private readonly Context _context;

       

        public DetalleMantenimientoRepository(Context context)
        {
            _context = context;
        }



        public int add(DetalleMantenimiento detalleMantenimiento)
        {
            _context.DetalleMantenimientos.Add(detalleMantenimiento);
            return _context.SaveChanges();
        }

        DetalleMantenimiento IDetalleMantenimiento.Find(int id)
        {
            return _context.DetalleMantenimientos.Find(id);
        }

        public int ActualizarDetalleManteminiento(DetalleMantenimiento detallemantenimiento)
        {
            _context.DetalleMantenimientos.Update(detallemantenimiento);
            return _context.SaveChanges();
        }

        public int EliminarDetalleMantenimiento(DetalleMantenimiento detalleMantenimiento)
        {
            _context.DetalleMantenimientos.Remove(detalleMantenimiento);
            return _context.SaveChanges();

        }


        //public List<DetalleMantenimiento> ObtenerDetalleXEstado(Estado estado)
        //{
        //    return _context.DetalleMantenimientos.Where(p => p.estado.Contains(estado)).ToList();
        //}
    }
}
