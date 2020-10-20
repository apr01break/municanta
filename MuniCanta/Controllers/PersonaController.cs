using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MuniCanta.Context;
using MuniCanta.Interfaces;
using MuniCanta.Models;

namespace MuniCanta.Controllers
{
    public class PersonaController : Controller
    {
        private readonly IPersonaRepository _personaRepository;
        public PersonaController(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        public IActionResult Login()
        {
            ViewData["Message"] = "";
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Persona persona)
        {
            var validar = _personaRepository.RegistrarPersona(persona);
            
            return RedirectToAction("Crear", "Licencia");
        }
    }
}
