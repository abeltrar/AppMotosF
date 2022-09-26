using System;
using System.Collections.Generic;
using System.Text;
using App.TallerMoto.Dominio.Entidades;
using App.TallerMoto.Persistencia.AppRepository;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public class UsuariosRepository : IUsuario
    {
        private readonly Context _context;
        public UsuariosRepository(Context context)
        {
            _context = context;
        }


        public int Add(Usuario usuarios)
        {
            _context.Usuarios.Add(usuarios);
            return _context.SaveChanges();
        }

        Usuario IUsuario.Find(int id)
        {
            return _context.Usuarios.Find(id);
        }

        public int ActualizarUsuario(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            return _context.SaveChanges();
        }

        public int EliminarUsuario(Usuario usuario)
        {
            _context.Usuarios.Remove(usuario);
            return _context.SaveChanges();
        }
    }
}