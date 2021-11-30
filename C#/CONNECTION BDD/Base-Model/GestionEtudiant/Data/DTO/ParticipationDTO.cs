using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiant.Data.DTO
{
    public partial class ParticipationDTOIN
    {
        public int? IdEtudiant { get; set; }
        public int? IdCours { get; set; }

    }

    public partial class ParticipationDTO
    {
        public int IdParticipation { get; set; }
        public int? IdEtudiant { get; set; }
        public int? IdCours { get; set; }

    }
    public partial class ParticipationDTOAvecEtudiant
    {
        public virtual EtudiantDTO Etudiant { get; set; }
    }

    public partial class PartcipationDTOAvecEtudiantEtCours
    {
        public virtual CourDTO Cours { get; set; }
        public virtual EtudiantDTO Etudiant { get; set; }
    }

    public partial class PartcipationDTOAvecCours
    {
        public virtual CourDTO Course { get; set; }
    }
}
