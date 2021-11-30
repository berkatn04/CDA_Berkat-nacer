using GestionEtudiant.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiant.Data.DTO
{
    public class CourDTO
    {
        public CourDTO()
        {
        }

        public string NomCours { get; set; }
        public string Description { get; set; }
        
    }

    public partial class CourDTOIn
    {
        public CourDTOIn()
        {
        }

        public int IdCours { get; set; }
        public string NomCours { get; set; }
        public string Description { get; set; }

    }


    public class CourDTOAvecParticipation
    {
        public CourDTOAvecParticipation()
        {
            Participation = new HashSet<ParticipationDTOAvecEtudiant>();
        }

        public string NomCours { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ParticipationDTOAvecEtudiant> Participation { get; set; }
    }
}
