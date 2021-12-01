using System;
using System.Collections.Generic;

#nullable disable

namespace GestionEtudiant.Data.Models
{
    public partial class Cour
    {
        public Cour()
        {
            Participation = new HashSet<Participation>();
        }

        public int IdCours { get; set; }
        public string NomCours { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Participation> Participation { get; set; }
    }
}
