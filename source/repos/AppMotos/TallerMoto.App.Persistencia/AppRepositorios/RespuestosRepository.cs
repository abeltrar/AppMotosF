using System;
using System.Collections.Generic;
using System.Text;
using TallerMoto.App.Dominio.Entidades;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public class RespuestosRepository : IRepuestos
    {
        private readonly AppContext _context;
        public RespuestosRepository(AppContext context)
        {
            _context = context;
        }



        public int Add(Repuestos repuestos)
        {
            _context.repuestos.Add(repuestos);
            return _context.SaveChanges();
        }

        Repuestos IRepuestos.Find(int id)
        {
            return _context.repuestos.Find(id);
        }

        public int ActualizarRepuesto(Repuestos repuesto)
        {
            _context.repuestos.Update(repuesto);
            return _context.SaveChanges();
        }

        public int EliminarRepuesto(Repuestos repuestos)
        {
            _context.repuestos.Remove(repuestos);
            return _context.SaveChanges();
        }
    }
}
