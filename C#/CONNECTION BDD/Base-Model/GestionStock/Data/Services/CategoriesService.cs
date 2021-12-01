using GestionStock.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Data.Services
{
    class CategoriesService
    {

        private readonly MyDbContext _context;

        public CategoriesService(MyDbContext context)
        {
            _context = context;
        }

        public void AddCategories(Categories obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Categorie.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteCategories(Categories obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Categorie.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Categories> GetAllCategories()
        {
            return _context.Categorie.ToList();
        }

        public Categories GetCategoriesById(int id)
        {
            return _context.Categorie.FirstOrDefault(obj => obj.IdCategories == id);
        }

        public void UpdateCategories(Categories obj)
        {
            _context.SaveChanges();
        }


    }
}
