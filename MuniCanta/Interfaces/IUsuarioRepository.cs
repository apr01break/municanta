using MuniCanta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuniCanta.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario ValidarUsuario(Usuario usuario);
    }
}
