using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuniCanta.Models
{
    public class BaseAuditoria
    {
        public string CodigoUsuario { get; set; }
        public DateTime FechaUsuario { get; set; }
        public string Estacion { get; set; }
        public string IpEstacion { get; set; }
    }
}
