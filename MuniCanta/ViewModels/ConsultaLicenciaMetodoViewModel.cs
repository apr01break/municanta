using Microsoft.AspNetCore.Mvc.Rendering;
using MuniCanta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuniCanta.ViewModels
{
    public class ConsultaLicenciaMetodoViewModel
    {
        public ConsultaLicenciaViewModel ConsultaLicencia { get; set; }
        public SelectList ListaTiposDocumento { get; set; }
        public PersonaLicencia PersonaLicencia { get; set; }
        public int ControlBusqueda;
    }
}
