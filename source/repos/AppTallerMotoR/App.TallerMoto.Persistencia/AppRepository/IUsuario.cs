using System;
using System.Collections.Generic;
using System.Text;
using App.TallerMoto.Dominio.Entidades;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public interface IUsuario
    {
        int Add(Usuario usuarios);
        Usuario Find(int id);

        int ActualizarUsuario(Usuario usuario);
        int EliminarUsuario(Usuario usuario);
    }
}