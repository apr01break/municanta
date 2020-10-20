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
    public class LicenciaRepository : ILicenciaRepository
    {
        ApplicationDbContext _db;
        public LicenciaRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public PersonaLicencia ConsultarLicencia(ConsultaLicenciaViewModel vm)
        {
            if (vm.TipoBusqueda == 1)
            {
                return _db.PersonaLicencia
                        .AsNoTracking()
                        .Include(l => l.Persona)
                        .Where(l => l.Persona.IdTipoDocumento == vm.TipoDocumento)
                        .Where(l => l.Persona.NumeroDocumento == vm.NumeroDocumento)
                        .Where(l => l.FechaFin.Date == (_db.PersonaLicencia
                                                            .Where(p=> p.IdPersona == l.IdPersona)
                                                            .Where(p => p.IdLicenciaPersona == l.IdLicenciaPersona)
                                                            .Max(p=> p.FechaFin))
                        )
                        .FirstOrDefault();
            }
            else if (vm.TipoBusqueda == 2)
            {
                return _db.PersonaLicencia
                        .AsNoTracking()
                        .Where(l => l.Persona.Nombres == vm.Nombres.ToUpper())
                        .Where(l => l.Persona.ApellidoPaterno == vm.ApellidoPaterno.ToUpper())
                        .Where(l => l.Persona.ApellidoMaterno == vm.ApellidoMaterno.ToUpper())
                        .Where(l => l.FechaFin.Date == (_db.PersonaLicencia
                                                            .Where(p => p.IdPersona == l.IdPersona)
                                                            .Where(p => p.IdLicenciaPersona == l.IdLicenciaPersona)
                                                            .Max(p => p.FechaFin))
                                                            )
                        .FirstOrDefault();
            }
            return null;
        }

        public int RegistrarLicencia(PersonaLicencia personaLicencia)
        {
            personaLicencia.IdLicenciaPersona = _db.PersonaLicencia
                                    .Where(p => p.IdPersona == personaLicencia.IdPersona)
                                    .Select(p => p.IdLicenciaPersona)
                                    .DefaultIfEmpty(0)
                                    .Max()
                                    + 1;
            personaLicencia.FechaUsuario = DateTime.Now;
            personaLicencia.Estacion = Environment.MachineName;
            personaLicencia.IpEstacion = Utilidad.ObtenerIpv4();
            personaLicencia.IdEmpresa = 1;
            _db.PersonaLicencia.Add(personaLicencia);
            return _db.SaveChanges();
        }
    }
}
