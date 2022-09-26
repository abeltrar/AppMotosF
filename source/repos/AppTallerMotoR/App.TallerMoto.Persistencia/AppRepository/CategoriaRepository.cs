using System;
using System.Collections.Generic;
using System.Text;
using App.TallerMoto.Dominio.Entidades;
using App.TallerMoto.Persistencia.AppRepository;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public class CategoriaRepository : ICategoria
    {
        private readonly Context _context;
        public CategoriaRepository(Context context)
        {
            _context = context;
        }

        public int add(Categorium categoria)
        {
            _context.Categoria.Add(categoria);
            return _context.SaveChanges();
        }

        public IEnumerable<Categorium> ObtenerCategorias()
        {
            return _context.Categoria;
        }

        Categorium ICategoria.Find(int id)
        {
            return _context.Categoria.Find(id);
        }

        int ICategoria.ActualizarCategoria(Categorium categoria)
        {
            _context.Categoria.Update(categoria);
            return _context.SaveChanges();
        }

        int ICategoria.EliminarCategoria(Categorium categoria)
        {
            _context.Categoria.Remove(categoria);
            return _context.SaveChanges();
        }



    }
}
