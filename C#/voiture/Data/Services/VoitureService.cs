using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using voiture.Data.Models;

namespace voiture.Data.Services
{
    public class VoitureService
    {
        private readonly MyDbContext _context;

        public VoitureService(MyDbContext context)
        {
            _context = context;
        }

        public void AddPersonnes(Voiture p)
        {
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p));
            }
            _context.Add(p);
            _context.SaveChanges();
        }
        public void DeletePersonne(Voiture p)
        {
            //si l'objet personne est null, on renvoi une exception
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p));
            }
            // on met à jour le context
            _context.Voitures.Remove(p);
            _context.SaveChanges();
        }
        public IEnumerable<Voiture> GetAllVoiture()
        {
            return _context.Voitures.ToList();
        }
        public Voiture GetPersonneById(int id)
        {
            return _context.Voitures.FirstOrDefault(p => p.IdVoiture == id);
        }
        public void UpdatePersonne(Voiture p)
        {       
                _context.SaveChanges();
            
        }

    }
}
