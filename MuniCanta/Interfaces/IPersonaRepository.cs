using MuniCanta.Models;
using MuniCanta.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuniCanta.Interfaces
{
    public interface IPersonaRepository
    {
        int RegistrarPersona(Persona persona);
        IEnumerable<PersonaViewModel> ListarPersonas();
    }
}
