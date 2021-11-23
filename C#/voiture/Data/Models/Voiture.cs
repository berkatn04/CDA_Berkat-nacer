using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace voiture.Data.Models
{
    public class Voiture
    {
        [Key]
        public int IdVehicule { get; set; }

        public string Marque { get; set; }
        public string Modele { get; set; }
    }
}
