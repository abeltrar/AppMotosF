using System;
using System.Collections.Generic;
using System.Text;
using TallerMoto.App.Dominio.Entidades;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public interface IPersona
    {
        int Add(Persona persona);
        Persona Find(int id);

        int ActualizarPersona(Persona persona);
        int EliminarPersona(Persona persona);
    }
}
