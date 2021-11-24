using AutoMapper;
using BaseToModel.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseToModel.Data.Services
{
    public class ServiceClient
    {
        private readonly MyDbContext _context;

        public ServiceClient(MyDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Client> GetAllClient()
        {
            return _context.Clients.ToList();
        }
        public void AddPersonnes(Client p)
        {
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p));
            }
            _context.Add(p);
            _context.SaveChanges();
        }
    }
}
