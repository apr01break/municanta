using Microsoft.EntityFrameworkCore;
using MuniCanta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuniCanta.Context
{
    public class ApplicationDbContext : DbContext
    {
        //public ApplicationDbContext()
        //{
        //}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<PersonaLicencia> PersonaLicencia { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDbFunction(typeof(Funciones).GetMethod(nameof(Funciones.EncriptarClave)));

            modelBuilder.Entity<PersonaLicencia>(entity =>
            {
                entity.HasKey(e => new { e.IdPersona, e.IdLicenciaPersona });
            });
        }
    }
}
