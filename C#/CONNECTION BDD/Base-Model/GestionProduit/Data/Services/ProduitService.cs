using GestionProduit.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduit.Data.Services
{
    public class ProduitService
    {

        private readonly gestionproduitContext _context;

        public ProduitService(gestionproduitContext context)
        {
            _context = context;
        }

        public void AddProduit(Produit obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Produits.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteProduit(Produit obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Produits.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Produit> GetAllProduits()
        {
            return _context.Produits.ToList();
        }

        public Produit GetProduitById(int id)
        {
            return _context.Produits.FirstOrDefault(obj => obj.IdProduit == id);
        }

        public void UpdateProduit(Produit obj)
        {
            _context.SaveChanges();
        }


    }
}
