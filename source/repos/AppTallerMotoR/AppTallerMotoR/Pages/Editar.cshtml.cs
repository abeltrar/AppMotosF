using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.TallerMoto.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TallerMoto.App.Persistencia.AppRepositorios;

namespace AppTallerMotoR.Pages
{
    public class EditarModel : PageModel
    {
        private IPersona _PersonaRepository = new PersonaRepository(new App.TallerMoto.Persistencia.AppRepository.Context());
        public Persona persona;
        public IActionResult OnGet(int id)
        {
            persona = _PersonaRepository.Find(id);
            if (persona == null)
            {
                return RedirectToPage("./Listar");
            }
            else
            {
                return Page();
            }

        }

        public IActionResult OnPost()
        {

            //captura los datos
            var id = Request.Form["id"];
            var nombre = Request.Form["nombre"];
            var cedula = Request.Form["cedula"];
            var telefono = Request.Form["telefono"];
            var direccion = Request.Form["direccion"];
            var rol = Request.Form["rol"];

            //valida los datos

            var personaResult = _PersonaRepository.Find(Convert.ToInt32(id));
            if (personaResult != null)
            {
                personaResult.Nombre = nombre;
                personaResult.Cedula = Convert.ToInt64(cedula);
                personaResult.Telefono = Convert.ToInt64(telefono);
                personaResult.Direccion = direccion;
                personaResult.IdRol = Convert.ToInt64(rol);

                var result =_PersonaRepository.ActualizarPersona(personaResult);

                if (result>0)
                {
                    ViewData["mesaje"] = "Se actualizó correctamente";
                }
                else
                {
                    ViewData["mesaje"] = "No se pudo actualizar";
                }

              
            }
            else
            {
                ViewData["mesaje"] = "La persona a actualizar no existe";
            }

            return RedirectToPage("./Listar");
        }

    }
}
