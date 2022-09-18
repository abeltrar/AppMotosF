using System;
using System.Collections.Generic;
using System.Text;
using TallerMoto.App.Dominio.Entidades;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public interface ICategoria
    {
        int add(Categoria categoria);
        Categoria Find(int id);
        IEnumerable<Categoria> ObtenerCategorias();
        int ActualizarCategoria(Categoria categoria);
        int EliminarCategoria(Categoria categoria);
    }
}

