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
                                                            .Where(p => p.IdPersona == l.IdPersona)
                                                            .Where(p => p.IdLicenciaPersona == l.IdLicenciaPersona)
                                                            .Max(p => p.FechaFin))
                        )
                        .FirstOrDefault();
            }
            else if (vm.TipoBusqueda == 2)
            {
                return _db.PersonaLicencia
                        .AsNoTracking()
                        .Include(l => l.Persona)
                        .Where(l => Utilidad.SinTilde(l.Persona.Nombres) == Utilidad.SinTilde(vm.Nombres.ToUpper()))
                        .Where(l => Utilidad.SinTilde(l.Persona.ApellidoPaterno) == Utilidad.SinTilde(vm.ApellidoPaterno.ToUpper()))
                        .Where(l => Utilidad.SinTilde(l.Persona.ApellidoMaterno) == Utilidad.SinTilde(vm.ApellidoMaterno.ToUpper()))
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
            if (personaLicencia.IdLicenciaPersona != 0)
            {
                _db.Attach(personaLicencia);
                _db.Entry(personaLicencia).Property(p => p.CodigoLicencia).IsModified = true;
                _db.Entry(personaLicencia).Property(p => p.FechaRenovacion).IsModified = true;
                _db.Entry(personaLicencia).Property(p => p.FechaInicio).IsModified = true;
                _db.Entry(personaLicencia).Property(p => p.FechaFin).IsModified = true;
            }
            else
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
            }
            return _db.SaveChanges();
        }

        public bool ValidarFechasLicencia(PersonaLicencia personaLicencia)
        {
            var x = _db.PersonaLicencia
                        .Where(p => p.IdPersona == personaLicencia.IdPersona)
                        .Where(p => personaLicencia.FechaInicio.Date > p.FechaInicio.Date && personaLicencia.FechaInicio.Date < p.FechaFin.Date)
                        .Count();

            var y = _db.PersonaLicencia
                        .Where(p => p.IdPersona == personaLicencia.IdPersona)
                        .Where(p => personaLicencia.FechaFin.Date > p.FechaInicio.Date && personaLicencia.FechaFin.Date < p.FechaFin.Date)
                        .Count();

            return !(x + y > 0);
        }

        public ICollection<LicenciaPersonaViewModel> ListarLicencias()
        {
            return _db.PersonaLicencia
                        .Select(s => new LicenciaPersonaViewModel
                        {
                            IdPersona = s.IdPersona,
                            IdLicenciaPersona = s.IdLicenciaPersona,
                            Nombres = s.Persona.Nombres,
                            ApellidoPaterno = s.Persona.ApellidoPaterno,
                            ApellidoMaterno = s.Persona.ApellidoMaterno,
                            TipoDocumento = _db.TipoDocumento
                                            .Where(t => t.IdTipoDocumento == s.Persona.IdTipoDocumento)
                                            .Select(t => t.Descripcion)
                                            .FirstOrDefault(),
                            NumeroDocumento = s.Persona.NumeroDocumento,
                            CodigoLicencia = s.CodigoLicencia,
                            FechaInicio = s.FechaInicio,
                            FechaFin = s.FechaFin,
                            FechaRenovacion = s.FechaRenovacion
                        })
                        .OrderByDescending(s => s.FechaFin)
                        .ToList();
        }
    }
}
