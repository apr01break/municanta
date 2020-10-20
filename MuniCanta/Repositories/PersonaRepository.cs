using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using MuniCanta.Context;
using MuniCanta.Interfaces;
using MuniCanta.Models;
using MuniCanta.Util;
using MuniCanta.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace MuniCanta.Repositories
{
    public class PersonaRepository : IPersonaRepository
    {
        ApplicationDbContext _db;
        public PersonaRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<PersonaViewModel> ListarPersonas()
        {
            return _db.Persona
                .Select(p => new PersonaViewModel {
                    IdPersona = p.IdPersona,
                    Nombres = p.Nombres,
                    ApellidoPaterno = p.ApellidoPaterno,
                    ApellidoMaterno = p.ApellidoMaterno,
                    DescripcionTipoDocumento = p.TipoDocumento.Descripcion,
                    NumeroDocumento = p.NumeroDocumento,
                    TextoCompleto = $"{p.Nombres} {p.ApellidoPaterno} {p.ApellidoMaterno} - {p.TipoDocumento.Descripcion}: {p.NumeroDocumento}"
                })
                .ToList();
        }

        public int RegistrarPersona(Persona persona)
        {
            persona.Nombres = persona.Nombres.ToUpperInvariant();
            persona.ApellidoMaterno = persona.ApellidoMaterno.ToUpperInvariant();
            persona.ApellidoPaterno = persona.ApellidoPaterno.ToUpperInvariant();
            persona.IdPersona = _db.Persona
                                    .Select(p=> p.IdPersona)
                                    .DefaultIfEmpty(0)
                                    .Max()
                                    + 1;
            persona.FechaUsuario = DateTime.Now;
            persona.Estacion = Environment.MachineName;
            persona.IpEstacion = Utilidad.ObtenerIpv4();
            _db.Persona.Add(persona);
            return _db.SaveChanges();
        }
    }
}
