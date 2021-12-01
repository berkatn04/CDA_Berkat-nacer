using System;
using System.Collections.Generic;

#nullable disable

namespace GestionEtudiant.Data.Models
{
    public partial class Etudiant
    {
        public Etudiant()
        {
            Participation = new HashSet<Participation>();
        }

        public int IdEtudiant { get; set; }
        public string Nom { get; set; }
        public int? IdGrade { get; set; }

        public virtual Grade Grade { get; set; }
        public virtual ICollection<Participation> Participation { get; set; }
    }
}
