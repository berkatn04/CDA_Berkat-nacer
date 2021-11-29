using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TableLiée.Data.Models
{
    public class Departements
    {

        public Departements()
        {
            LesVilles = new HashSet<Villes>();
        }
        [Key]
        public int IdDepartement { get; set; }

        public string NomDepartement { get; set; }
        public int IdVille { get; set; }
        public ICollection<Villes> LesVilles { get; set; }
    }
}
