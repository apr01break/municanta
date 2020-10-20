using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MuniCanta.Models
{
    public class PersonaLicencia : BaseAuditoria
    {
        public int IdLicenciaPersona { get; set; }
        public int IdPersona { get; set; }
        public string CodigoLicencia { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaRenovacion { get; set; }
        public int IdEmpresa { get; set; }
        public Empresa Empresa { get; set; }
        [ForeignKey("IdPersona")]
        public Persona Persona { get; set; }
    }
}
