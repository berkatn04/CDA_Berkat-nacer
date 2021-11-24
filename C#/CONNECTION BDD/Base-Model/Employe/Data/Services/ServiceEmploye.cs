
using GestionEmploye.Data.Models;
using GestionEmploye.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEmploye.Data.Services
{
    public class ServiceEmploye
    {
        private readonly MyDbContext _context;

        public ServiceEmploye(MyDbContext context)
        {
            _context = context;
        }
        public void AddPersonnes(Employes p)
        {
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p));
            }
            _context.Add(p);
            _context.SaveChanges();
        }
        public void DeletePersonne(Employes p)
        {
            //si l'objet personne est null, on renvoi une exception
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p));
            }
            // on met à jour le context
            _context.employes.Remove(p);
            _context.SaveChanges();
        }
        public IEnumerable<Employes>GetAllEmploye()
        {
            return _context.employes.ToList();
        }
        public Employes GetEmployeById(int id)
        {
            return _context.employes.FirstOrDefault(p => p.IdEmploye == id);
        }
        public void UpdateEmploye(Employes p)
        {
            _context.SaveChanges();

        }
    }
}
