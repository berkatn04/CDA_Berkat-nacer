using System;
using System.Collections.Generic;

#nullable disable

namespace GestionEtudiant.Data.Models
{
    public partial class Participation
    {
        public int IdParticipation { get; set; }
        public int? IdEtudiant { get; set; }
        public int? IdCours { get; set; }
    }
}
