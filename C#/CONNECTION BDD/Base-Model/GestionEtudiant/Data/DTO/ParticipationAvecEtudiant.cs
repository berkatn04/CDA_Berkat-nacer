using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiant.Data.DTO
{
    public class ParticipationAvecEtudiant
    {
        
        
            public int IdParticipation { get; set; }
            public int? IdEtudiant { get; set; }
            public int? IdCours { get; set; }

            public virtual EtudiantDTO Etudiant { get; set; }
        
    }
}
