using GestionProduit.Data.DTO;
using GestionProduit.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduit.Data.Services
{
    public class PreparationService
    {

        private readonly gestionproduitContext _context;

        public PreparationService(gestionproduitContext context)
        {
            _context = context;
        }

        public void AddPreparation(Preparation obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Preparations.Add(obj);
            _context.SaveChanges();
        }

        public void DeletePreparation(Preparation obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Preparations.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Preparation> GetAllPreparations()
        {
            return _context.Preparations.ToList();
        }

        public Preparation GetPreparationById(int id)
        {
            return _context.Preparations.FirstOrDefault(obj => obj.IdPreparation == id);
        }

        public void UpdatePreparation(Preparation obj)
        {
            _context.SaveChanges();
        }


    }
}
