using System;
using System.Collections.Generic;
using System.Text;
using App.TallerMoto.Dominio.Entidades;
using App.TallerMoto.Persistencia.AppRepository;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public class RespuestosRepository : IRepuestos
    {
        private readonly Context _context;
        public RespuestosRepository(Context context)
        {
            _context = context;
        }



        public int Add(Repuesto repuestos)
        {
            _context.Repuestos.Add(repuestos);
            return _context.SaveChanges();
        }

        Repuesto IRepuestos.Find(int id)
        {
            return _context.Repuestos.Find(id);
        }

        public int ActualizarRepuesto(Repuesto repuesto)
        {
            _context.Repuestos.Update(repuesto);
            return _context.SaveChanges();
        }

        public int EliminarRepuesto(Repuesto repuestos)
        {
            _context.Repuestos.Remove(repuestos);
            return _context.SaveChanges();
        }
    }
}
