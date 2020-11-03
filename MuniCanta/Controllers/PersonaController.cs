using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MuniCanta.Context;
using MuniCanta.Interfaces;
using MuniCanta.Models;

namespace MuniCanta.Controllers
{
    public class PersonaController : Controller
    {
        private readonly IPersonaRepository _personaRepository;
        private readonly IHttpContextAccessor _contextAccessor;
        public PersonaController(IPersonaRepository personaRepository, IHttpContextAccessor contextAccessor)
        {
            _personaRepository = personaRepository;
            _contextAccessor = contextAccessor;
        }

        public IActionResult Login()
        {
            ViewData["Message"] = "";
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Persona persona)
        {
            persona.CodigoUsuario = _contextAccessor.HttpContext.User.Identity.Name;
            var validar = _personaRepository.RegistrarPersona(persona);
            
            return RedirectToAction("Crear", "Licencia");
        }
    }
}
