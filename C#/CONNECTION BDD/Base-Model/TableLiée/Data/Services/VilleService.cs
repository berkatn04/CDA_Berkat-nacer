using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TableLiée.Data.Models;

namespace TableLiée.Data.Services
{

    public class VilleService
    {
        private readonly MyDbContext _context;

        public VilleService(MyDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Villes> GetAllVille()
        {
            return _context.Ville.ToList();
        }
    }
}
