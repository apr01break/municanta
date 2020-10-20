using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MuniCanta.Models
{
    public class Empresa : BaseAuditoria
    {
        [Key]
        public int IdEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public string Direccion { get; set; }
    }
}
