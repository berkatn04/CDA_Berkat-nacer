using _6._Api_Student.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6._Api_Student.Data.Services
{
    public class ParticipationServices
    {

        private readonly StudentContext _context;

        public ParticipationServices(StudentContext context)
        {
            _context = context;
        }

        public void AddParticipation(Participation obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Participation.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteParticipation(Participation obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Participation.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Participation> GetAllParticipation()
        {
            return _context.Participation.Include("Course").Include("Student").ToList();
        }

        public Participation GetParticipationById(int id)
        {
            return _context.Participation.Include("Course").Include("Student").FirstOrDefault(obj => obj.IdParticipation == id);
        }

        public void UpdateParticipation(Participation obj)
        {
            _context.SaveChanges();
        }


    }
}
