using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MuniCanta.Models
{
    public class TipoDocumento
    {
        [Key]
        public int IdTipoDocumento { get; set; }
        public string Descripcion { get; set; }
    }
}
