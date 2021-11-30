using System;
using System.Collections.Generic;

#nullable disable

namespace GestionEtudiant.Data.Models
{
    public partial class Etudiant
    {
        public int IdEtudiant { get; set; }
        public string Nom { get; set; }
        public int IdGrade { get; set; }
    }
}
