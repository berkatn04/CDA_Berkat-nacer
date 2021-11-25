using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Models;
using WebApplication1.Models;

namespace WebApplication1.Data.Services
{
    public class Service
    {
        private readonly MyDbContext _context;

        public Service(MyDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Voitures> GetAllEmploye()
        {
            return _context.Voiture.ToList();
        }
    }
}
