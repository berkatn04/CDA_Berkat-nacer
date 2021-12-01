using GestionEtudiant.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data.Models;

namespace GestionEtudiant.Data.Services
{
    public class EtudiantsService
    {

        private readonly etudiantContext _context;

        public EtudiantsService(etudiantContext context)
        {
            _context = context;
        }

        public void AddEtudiant(Etudiant obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Etudiants.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteEtudiant(Etudiant obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Etudiants.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Etudiant> GetAllEtudiants()
        {
            return _context.Etudiants.Include("Grade").Include("Participation.Cours").ToList();
        }

        public Etudiant GetEtudiantById(int id)
        {
            return _context.Etudiants.Include("Grade").Include("Participation.Cours").FirstOrDefault(obj => obj.IdEtudiant == id);
        }

        public void UpdateEtudiant(Etudiant obj)
        {
            _context.SaveChanges();
        }


    }
}
