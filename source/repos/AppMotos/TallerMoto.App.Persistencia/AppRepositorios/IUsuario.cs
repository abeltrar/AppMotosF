using System;
using System.Collections.Generic;
using System.Text;
using TallerMoto.App.Dominio.Entidades;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public interface IUsuario
    {
        int Add(Usuarios usuarios);
        Usuarios Find(int id);

        int ActualizarUsuario(Usuarios usuario);
        int EliminarUsuario(Usuarios usuario);
    }
}