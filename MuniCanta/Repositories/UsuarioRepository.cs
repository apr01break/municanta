using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Identity;
using MuniCanta.Context;
using MuniCanta.Interfaces;
using MuniCanta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace MuniCanta.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        ApplicationDbContext _db;
        public UsuarioRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public Usuario ValidarUsuario(Usuario usuario)
        {
            string password = "Alonso";
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                                                    password: password,
                                                    salt: salt,
                                                    prf: KeyDerivationPrf.HMACSHA1,
                                                    iterationCount: 10000,
                                                    numBytesRequested: 256 / 8));
            Console.WriteLine("hash_pass:"+hashed);
            var model = _db.Usuario
                            .Where(u => u.CodigoUsuario == usuario.CodigoUsuario)
                            .Where(u => u.Password == Funciones.EncriptarClave(usuario.CodigoUsuario, usuario.Password))
                            .FirstOrDefault();
            return model;
        }
    }
}
