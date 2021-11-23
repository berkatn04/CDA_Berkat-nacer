using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace voiture.Data.Services
{
    public class VoitureService
    {
        private readonly MyDbContext _context;

        public VoitureService(MyDbContext context)
        {
            _context = context;
        }
    }
}
