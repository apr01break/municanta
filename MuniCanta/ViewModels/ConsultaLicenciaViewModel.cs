using MuniCanta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuniCanta.ViewModels
{
    public class ConsultaLicenciaViewModel
    {
        public int TipoBusqueda { get; set; }

        public int TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }

        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
    }
}
