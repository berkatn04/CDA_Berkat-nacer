using System;
using System.Collections.Generic;

#nullable disable

namespace GestionEtudiant.Data.Models
{
    public partial class Cour
    {
        public int IdCours { get; set; }
        public string NomCours { get; set; }
        public string Description { get; set; }
    }
}
