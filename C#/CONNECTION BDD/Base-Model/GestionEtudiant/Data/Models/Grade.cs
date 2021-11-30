using System;
using System.Collections.Generic;

#nullable disable

namespace GestionEtudiant.Data.Models
{
    public partial class Grade
    {
        public int IdGrade { get; set; }
        public string NomGrade { get; set; }

        public virtual ICollection<Etudiant> Students { get; set; }
    }
}
