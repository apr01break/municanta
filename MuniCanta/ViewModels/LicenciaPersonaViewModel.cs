using Microsoft.AspNetCore.Mvc.Rendering;
using MuniCanta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuniCanta.ViewModels
{
    public class LicenciaPersonaViewModel
    {
        public int IdPersona { get; set; }
        public int IdLicenciaPersona { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string CodigoLicencia { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaRenovacion { get; set; }
    }
}
