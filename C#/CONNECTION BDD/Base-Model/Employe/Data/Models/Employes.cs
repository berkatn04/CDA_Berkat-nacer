using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


#nullable disable

namespace GestionEmploye.Data.Models
{
    public partial class Employes
    {
        [Key]
        public int IdEmploye { get; set; }

        public string Nom { get; set; }
        public string Prenom { get; set; }
    }
}
