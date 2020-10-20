using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MuniCanta.Context;
using MuniCanta.Interfaces;
using MuniCanta.Models;

namespace MuniCanta.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IHttpContextAccessor _contextAccessor;
        public UsuarioController(IUsuarioRepository usuarioRepository, IHttpContextAccessor contextAccessor)
        {
            _usuarioRepository = usuarioRepository;
            _contextAccessor = contextAccessor;
        }

        public IActionResult Login()
        {
            ViewData["Message"] = "";
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario usuario)
        {
            var validar = _usuarioRepository.ValidarUsuario(usuario);
            if (validar == null)
            {
                ViewData["Message"] = "Datos incorrectos";
                return View();
            }
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, validar.NombreUsuario),
                new Claim(ClaimTypes.Name, validar.NombreUsuario),
                new Claim("clave" , validar.Password),
                new Claim("idpersona" , validar.CodigoUsuario)
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            _contextAccessor.HttpContext.SignInAsync(principal);
            return RedirectToAction("Crear", "Licencia");
        }
    }
}
