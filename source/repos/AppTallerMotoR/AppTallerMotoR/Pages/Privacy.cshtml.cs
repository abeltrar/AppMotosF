using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.TallerMoto.Dominio.Entidades;
using TallerMoto.App.Persistencia.AppRepositorios;

namespace AppTallerMotoR.Pages
{
    public class PrivacyModel : PageModel
    {
        private IPersona _PersonaRepository = new PersonaRepository(new App.TallerMoto.Persistencia.AppRepository.Context()); 
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
           var nombre = Request.Form["nombre"];
           var cedula = Request.Form["cedula"];
           var telefono = Request.Form["telefono"];
           var direccion = Request.Form["direccion"];
           var rol = Request.Form["rol"];

            // validacion de datos

            var persona = new Persona
            {
                Nombre = nombre,
                Cedula = Convert.ToInt64(cedula),
                Telefono = Convert.ToInt64(telefono),
                Direccion = direccion,
                IdRol = Convert.ToInt64(rol)
            };

           var result = _PersonaRepository.Add(persona);
            if (result>0)
            {
                Console.WriteLine("Insertado con éxito");
            }
            else
            {
                Console.WriteLine("Falla en insertar");
            }

        }
    }
}
