using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TableLiée.Data.Models
{
    public class Villes
    {
        [Key]
        public int IdVille { get; set; }


        public string NomVille { get; set; }

    }
}
