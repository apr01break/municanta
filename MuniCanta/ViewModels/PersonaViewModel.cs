using MuniCanta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuniCanta.ViewModels
{
    public class PersonaViewModel : Persona
    {
        public string DescripcionTipoDocumento { get; set; }
        public string TextoCompleto { get; set; }
    }
}
