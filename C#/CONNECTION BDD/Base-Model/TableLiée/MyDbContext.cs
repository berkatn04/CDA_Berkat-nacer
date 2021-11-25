using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TableLiée.Data.Models;

namespace TableLiée
{
    public class MyDbContext : DbContext
    {
        public DbSet<Departements> Departement { get; set; }
        public DbSet<Villes> Ville { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        
    }
}
