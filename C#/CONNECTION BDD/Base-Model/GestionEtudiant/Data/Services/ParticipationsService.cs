using GestionEtudiant.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data.Models;

namespace GestionEtudiant.Data.Services
{
    public class ParticipationsService
    {

        private readonly etudiantContext _context;

        public ParticipationsService(etudiantContext context)
        {
            _context = context;
        }

        public void AddParticipation(Participation obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Participations.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteParticipation(Participation obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Participations.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Participation> GetAllParticipations()
        {
            return _context.Participations.Include("Cours").Include("Etudiant").ToList();
        }

        public Participation GetParticipationById(int id)
        {
            return _context.Participations.Include("Cours").Include("Etudiant").FirstOrDefault(obj => obj.IdParticipation == id);
        }

        public void UpdateParticipation(Participation obj)
        {
            _context.SaveChanges();
        }


    }
}
