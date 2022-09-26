using System;
using System.Collections.Generic;
using System.Text;
using App.TallerMoto.Dominio.Entidades;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public interface IPersona
    {
        int Add(Persona persona);
        Persona Find(int id);

        int ActualizarPersona(Persona persona);
        int EliminarPersona(Persona persona);
        List<Persona> ObtenerTodo();
     
        IEnumerable<Persona> FindByName(string name);
        IEnumerable<Persona> FindMultipleParameter(string value);
        int Update(Persona persona);
        int Delete(Persona persona);

        IEnumerable<Persona> ObtenerTodasPersonas();
        List<Persona> ObtenerPersonaPorNombre(string nombre);
        IEnumerable<Persona> Buscador(string busqueda);
       
    }
}
