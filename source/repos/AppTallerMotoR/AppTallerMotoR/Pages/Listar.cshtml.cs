using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using App.TallerMoto.Dominio.Entidades;
using TallerMoto.App.Persistencia.AppRepositorios;

namespace AppTallerMotoR.Pages
{
    public class ListarModel : PageModel
    {
        private IPersona _PersonaRepository = new PersonaRepository(new App.TallerMoto.Persistencia.AppRepository.Context());
        public List<Persona> ListadoPersonas { get; set; }
        public void OnGet()
        {
            ListadoPersonas = new List<Persona>();
            ListadoPersonas = _PersonaRepository.ObtenerTodo();
        }
    }
}
