using System;
using System.Collections.Generic;
using System.Text;
using App.TallerMoto.Dominio.Entidades;
using App.TallerMoto.Persistencia.AppRepository;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public class DetalleXRepuestoRepository : IDetalleXRepuesto
    {
        private readonly Context _context;
        public DetalleXRepuestoRepository(Context context)
        {
            _context = context;
        }



        public int add(DetalleXrepuesto detalleXRepuesto)
        {
            _context.DetalleXrepuestos.Add(detalleXRepuesto);
            return _context.SaveChanges();
        }

        DetalleXrepuesto IDetalleXRepuesto.Find(int id)
        {
            return _context.DetalleXrepuestos.Find(id);
        }
        public int ActualizarDetalleXRepuesto(DetalleXrepuesto detallexrepuesto)
        {
            _context.DetalleXrepuestos.Update(detallexrepuesto);
            return _context.SaveChanges();
        }

        public int EliminarDetalleXRepuesto(DetalleXrepuesto detalleXRepuesto)
        {
            _context.DetalleXrepuestos.Remove(detalleXRepuesto);
            return _context.SaveChanges();
        }
    }
}
