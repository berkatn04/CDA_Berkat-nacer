using GestionStock.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Data.Services
{
    class TypeProduitsService
    {

        private readonly MyDbContext _context;

        public TypeProduitsService(MyDbContext context)
        {
            _context = context;
        }

        public void AddTypeProduits(TypeProduits obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.TypeProduit.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteTypeProduits(TypeProduits obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.TypeProduit.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<TypeProduits> GetAllTypeProduits()
        {
            return _context.TypeProduit.ToList();
        }

        public TypeProduits GetTypeProduitsById(int id)
        {
            return _context.TypeProduit.FirstOrDefault(obj => obj.IdTypeProduits == id);
        }

        public void UpdateTypeProduits(TypeProduits obj)
        {
            _context.SaveChanges();
        }


    }
}
