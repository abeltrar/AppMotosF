using System;
using System.Collections.Generic;
using System.Text;
using App.TallerMoto.Dominio.Entidades;

namespace TallerMoto.App.Persistencia.AppRepositorios
{
    public interface ICategoria
    {
        int add(Categorium categoria);
        Categorium Find(int id);
        IEnumerable<Categorium> ObtenerCategorias();
        int ActualizarCategoria(Categorium categoria);
        int EliminarCategoria(Categorium categoria);
    }
}

