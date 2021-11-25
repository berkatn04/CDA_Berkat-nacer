using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TableLiée.Data.Models;

namespace TableLiée.Data.Services
{
    public class DepartementService
    {
        private readonly MyDbContext _context;

        public DepartementService(MyDbContext context)
        {
            _context = context;

        }


        public IEnumerable<Departements> GetAllDepartement()
        {
            var liste = (from Departement in _context.Departement
                         join Ville in _context.Ville
                         on Departement.IdVille equals Ville.IdVille
                         select new Departements
                         {
                             IdDepartement = Departement.IdDepartement,
                             NomDepartement = Departement.NomDepartement,
                             IdVille = Ville.IdVille,
                             Ville = Ville
                         }).ToList();
            return liste;
        }
    }
}