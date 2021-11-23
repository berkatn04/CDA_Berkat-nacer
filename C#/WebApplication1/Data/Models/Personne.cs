using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WebApplication1.Data.Models
{
    public partial class Personne
    {
        [Key]
        public int IdPersonne { get; set; }


        public string Nom { get; set; }
        public string Prenom { get; set; }
    }
}
