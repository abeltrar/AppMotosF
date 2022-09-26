using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App.TallerMoto.Dominio.Entidades;
using App.TallerMoto.Persistencia.AppRepository;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public class PersonaRepository : IPersona

    {
        private readonly Context _context;
        public PersonaRepository(Context context)
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

        public List<Persona> ObtenerTodo()
        {
            return _context.Personas.ToList();
        }

        public IEnumerable<Persona> FindByName(string name)
        {
            return _context.Personas.Where(p => p.Nombre.Contains(name));
        }

        public IEnumerable<Persona> FindMultipleParameter(string value)
        {
            return _context.Personas.Where(p => p.Nombre.Contains(value) || p.Cedula.ToString().Contains(value) || p.Direccion.Contains(value));
        }

        public int Update(Persona persona)
        {
            _context.Personas.Update(persona);
            return _context.SaveChanges();
        }

        public int Delete(Persona persona)
        {
            _context.Personas.Remove(persona);
            return _context.SaveChanges();
        }

        public IEnumerable<Persona> ObtenerTodasPersonas()
        {
            return _context.Personas;
        }

        public List<Persona> ObtenerPersonaPorNombre(string nombre)
        {
            return _context.Personas.Where(p => p.Nombre.Contains(nombre)).ToList();

        }

        public IEnumerable<Persona> Buscador(string busqueda)
        {
            return _context.Personas.Where(p => p.Nombre.Contains(busqueda) || p.Cedula.ToString().Contains(busqueda) || p.Direccion.Contains(busqueda));
        }
    }
}
