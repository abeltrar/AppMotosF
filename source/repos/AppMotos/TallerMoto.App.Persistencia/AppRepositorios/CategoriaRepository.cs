using System;
using System.Collections.Generic;
using System.Text;
using TallerMoto.App.Dominio.Entidades;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public class CategoriaRepository : ICategoria
    {
        private readonly AppContext _context;
        public CategoriaRepository(AppContext context)
        {
            _context = context;
        }

        public int add(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            return _context.SaveChanges();
        }

        public IEnumerable<Categoria> ObtenerCategorias()
        {
            return _context.Categorias;
        }

        Categoria ICategoria.Find(int id)
        {
            return _context.Categorias.Find(id);
        }

        int ICategoria.ActualizarCategoria(Categoria categoria)
        {
            _context.Categorias.Update(categoria);
            return _context.SaveChanges();
        }

        int ICategoria.EliminarCategoria(Categoria categoria)
        {
            _context.Categorias.Remove(categoria);
            return _context.SaveChanges();
        }



    }
}
