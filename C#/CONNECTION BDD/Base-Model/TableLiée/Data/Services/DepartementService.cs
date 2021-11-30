using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TableLiée.Data.DTO;
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
            var liste = (from e1 in _context.Ville
                         join e2 in _context.Departement
                         on e1.IdDepartement equals e2.IdDepartement
                         select new Departements
                         {
                             IdDepartement = e1.IdDepartement,
                             NomDepartement = e2.NomDepartement,
                             LesVilles = _context.Ville.Where(v => v.IdDepartement == e2.IdDepartement).ToList()
                         }).ToList();
            return liste;
        }
        
        public Departements GetDepartementById(int id)
        {
            var ent = (from e1 in _context.Departement
                       join e2 in _context.Ville
                       on e1.IdVille equals e2.IdVille
                       select new Departements
                       {
                           IdDepartement = e1.IdDepartement,
                           NomDepartement = e1.NomDepartement,
                           IdVille = e2.IdVille,
                           LesVilles = _context.Ville.Where(v => v.IdDepartement == e2.IdDepartement).ToList()
                       }).FirstOrDefault(e => e.IdDepartement == id);
            return ent;
        }
        
        public void AddDepartement(DepartementDTOIN ent)
        {
            if (ent == null)
            {
                throw new ArgumentNullException(nameof(ent));
            }
            var entite = new Departements()
            {
                NomDepartement = ent.NomDepartement,

            };
            _context.Add(ent);
            _context.SaveChanges();

        }
        public void UpdateDepartement(Departements ent)
        {
            if (ent == null)
            {
                throw new ArgumentNullException(nameof(ent));
            }
            var entite = new Departements()
            {
                IdDepartement = ent.IdDepartement,
                NomDepartement = ent.NomDepartement,
                IdVille = ent.IdVille,
            };
            _context.Update(ent);
            _context.SaveChanges();

        }
    }
}