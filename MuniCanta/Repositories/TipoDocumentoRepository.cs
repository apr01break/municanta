using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using MuniCanta.Context;
using MuniCanta.Interfaces;
using MuniCanta.Models;
using MuniCanta.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace MuniCanta.Repositories
{
    public class TipoDocumentoRepository : ITipoDocumentoRepository
    {
        ApplicationDbContext _db;
        public TipoDocumentoRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<TipoDocumento> ListarTiposDeDocumento()
        {
            return _db.TipoDocumento.AsNoTracking().ToList();
        }
    }
}
