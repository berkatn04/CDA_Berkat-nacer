using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TableLiée.Data.DTO
{
    public class DepartementDTO
    {
        public string NomDepartement { get; set; }

        public VilleDTO villedto { get; set;  }
    }
}
