using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TableLiée.Data.Models
{
    public class Departements
    {
        [Key]
        public int IdDepartement { get; set; }

        public string NomDepartement { get; set; }
        public int IdVille { get; set; }
        public Villes Ville { get; set; }
    }
}
