using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TableLiée.Data.Models;

namespace TableLiée.Data.DTO
{
    public class DepartementDTO
    {
        public string NomDepartement { get; set; }

        public ICollection<Villes> ville { get; set;  }
    }
}
