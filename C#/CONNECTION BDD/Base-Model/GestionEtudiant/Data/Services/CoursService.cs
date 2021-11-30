﻿using GestionEtudiant.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiant.Data.Services
{
    public class CoursService
    {

        private readonly etudiantContext _context;

        public CoursService(etudiantContext context)
        {
            _context = context;
        }

        public void AddCour(Cour obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Cours.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteCours(Cour obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Cours.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Cour> GetAllCours()
        {
            return _context.Cours.ToList();
        }

        public Cour GetCoursById(int id)
        {
            return _context.Cours.FirstOrDefault(obj => obj.IdCours == id);
        }

        public void UpdateCours(Cour obj)
        {
            _context.SaveChanges();
        }


    }
}
