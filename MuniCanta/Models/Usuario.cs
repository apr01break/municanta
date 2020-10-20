using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MuniCanta.Models
{
    public class Usuario
    {
        [Key]
        public string CodigoUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
    }
}
