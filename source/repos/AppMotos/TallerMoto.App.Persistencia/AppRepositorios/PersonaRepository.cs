using System;
using System.Collections.Generic;
using System.Text;
using TallerMoto.App.Dominio.Entidades;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public class PersonaRepository : IPersona

    {
        private readonly AppContext _context;
        public PersonaRepository(AppContext context)
        {
            _context = context;
        }


        public int Add(Persona persona)
        {
            _context.Personas.Add(persona);
            return _context.SaveChanges();

        }

        Persona IPersona.Find(int id)
        {
            return _context.Personas.Find(id);
        }

        public int ActualizarPersona(Persona persona)
        {
            _context.Personas.Update(persona);
            return _context.SaveChanges();
        }

        public int EliminarPersona(Persona persona)
        {
            _context.Personas.Remove(persona);
            return _context.SaveChanges();

        }
    }
}
