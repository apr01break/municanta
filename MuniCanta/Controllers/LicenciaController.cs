using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MuniCanta.Context;
using MuniCanta.Interfaces;
using MuniCanta.Models;
using MuniCanta.ViewModels;

namespace MuniCanta.Controllers
{
    public class LicenciaController : Controller
    {
        private readonly ILicenciaRepository _licenciaRepository;
        private readonly IPersonaRepository _personaRepository;
        private readonly ITipoDocumentoRepository _tipoDocumentoRepository;
        private readonly IHttpContextAccessor _contextAccessor;
        public LicenciaController(ILicenciaRepository licenciaRepository,
                                    IPersonaRepository personaRepository,
                                    ITipoDocumentoRepository tipoDocumentoRepository,
                                    IHttpContextAccessor contextAccessor)
        {
            _licenciaRepository = licenciaRepository;
            _personaRepository = personaRepository;
            _tipoDocumentoRepository = tipoDocumentoRepository;
            _contextAccessor = contextAccessor;
        }

        public IActionResult Crear()
        {
            if (_contextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                ViewBag.TipoMensaje = TempData["TipoMensaje"];
                ViewBag.Mensaje = TempData["Mensaje"];
                TempData["TipoMensaje"] = null;
                TempData["Mensaje"] = null;
                ViewBag.ListaPersonas = new SelectList(_personaRepository.ListarPersonas(),
                                                nameof(PersonaViewModel.IdPersona),
                                                nameof(PersonaViewModel.TextoCompleto));
                ViewBag.ListaTipoDocumento = new SelectList(_tipoDocumentoRepository.ListarTiposDeDocumento(),
                                                nameof(TipoDocumento.IdTipoDocumento),
                                                nameof(TipoDocumento.Descripcion));
                ViewBag.Licencias = _licenciaRepository.ListarLicencias();
                return View();
            }
            return RedirectToAction("Login", "Usuario");
        }

        [HttpPost]
        public IActionResult Crear(PersonaLicencia personaLicencia)
        {
            if (_contextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                if (_licenciaRepository.ValidarFechasLicencia(personaLicencia))
                {
                    personaLicencia.CodigoUsuario = _contextAccessor.HttpContext.User.Identity.Name;
                    var resultado = _licenciaRepository.RegistrarLicencia(personaLicencia);
                    if (resultado != 0)
                    {
                        TempData["TipoMensaje"] = "success";
                        TempData["Mensaje"] = "Guardado correctamente";
                        return RedirectToAction("Crear", "Licencia");
                    }

                    TempData["TipoMensaje"] = "error";
                    TempData["Mensaje"] = "Ocurrió un error al guardar";
                    return RedirectToAction("Crear", "Licencia");
                }
                TempData["TipoMensaje"] = "error";
                TempData["Mensaje"] = "Las fechas de expedicion y vencimientos estan registradas en otra licencia";
                return RedirectToAction("Crear", "Licencia");
            }
            return RedirectToAction("Login", "Usuario");
        }

        [HttpPost]
        public IActionResult Editar(PersonaLicencia personaLicencia)
        {
            if (_contextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                if (_licenciaRepository.ValidarFechasLicencia(personaLicencia))
                {
                    personaLicencia.CodigoUsuario = _contextAccessor.HttpContext.User.Identity.Name;
                    var resultado = _licenciaRepository.RegistrarLicencia(personaLicencia);
                    if (resultado != 0)
                    {
                        TempData["TipoMensaje"] = "success";
                        TempData["Mensaje"] = "Guardado correctamente";
                        return RedirectToAction("Crear", "Licencia");
                    }

                    TempData["TipoMensaje"] = "error";
                    TempData["Mensaje"] = "Ocurrió un error al guardar";
                    return RedirectToAction("Crear", "Licencia");
                }
                TempData["TipoMensaje"] = "error";
                TempData["Mensaje"] = "Las fechas de expedicion y vencimientos estan registradas en otra licencia";
                return RedirectToAction("Crear", "Licencia");
            }
            return RedirectToAction("Login", "Usuario");
        }

        public IActionResult Consultar()
        {
            var vm = new ConsultaLicenciaMetodoViewModel();
            vm.ListaTiposDocumento = new SelectList(_tipoDocumentoRepository.ListarTiposDeDocumento(),
                                                        nameof(TipoDocumento.IdTipoDocumento),
                                                        nameof(TipoDocumento.Descripcion));
            vm.ControlBusqueda = 0;
            return View(vm);
        }

        [HttpPost]
        public IActionResult Consultar(ConsultaLicenciaMetodoViewModel vm)
        {
            vm.ListaTiposDocumento = new SelectList(_tipoDocumentoRepository.ListarTiposDeDocumento(),
                                                        nameof(TipoDocumento.IdTipoDocumento),
                                                        nameof(TipoDocumento.Descripcion));
            vm.ControlBusqueda = 1;
            vm.PersonaLicencia = _licenciaRepository.ConsultarLicencia(vm.ConsultaLicencia);
            vm.ConsultaLicencia = new ConsultaLicenciaViewModel();
            return View(vm);
        }
    }
}
