using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuniCanta.Context
{
    public class Funciones
    {
        [DbFunction("F_ENCRIPTAR_CLAVE", "lite_municanta")]
        public static string EncriptarClave(string GUIA, string clave)
        {
            throw new NotImplementedException();
        }
    }
}
