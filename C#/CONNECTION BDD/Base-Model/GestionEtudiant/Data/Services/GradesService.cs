using Microsoft.EntityFrameworkCore;
using GestionEtudiant.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data.Models;

namespace  GestionEtudiant.Data.Services
    
{
    public class GradesService
    {

        private readonly etudiantContext _context;

        public GradesService(etudiantContext context)
        {
            _context = context;
        }

        public void AddGrade(Grade obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Grades.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteGrade(Grade obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Grades.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Grade> GetAllGrade()
        {
            return _context.Grades.Include("Etudiants").ToList();
        }

        public Grade GetGradeById(int id)
        {
            return _context.Grades.Include("Etudiants").FirstOrDefault(obj => obj.IdGrade == id);
        }

        public void UpdateGrade(Grade obj)
        {
            _context.SaveChanges();
        }


    }
}
