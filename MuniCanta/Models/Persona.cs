using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MuniCanta.Models
{
    public class Persona : BaseAuditoria
    {
        [Key]
        public int IdPersona { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Direccion { get; set; }
        public IEnumerable<PersonaLicencia> PersonaLicencias { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
    }
}
