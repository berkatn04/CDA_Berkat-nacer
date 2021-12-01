using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiant.Data.DTO
{
    public class EtudiantDTO
    {
        public EtudiantDTO()
        {
            Participation = new HashSet<PartcipationDTOAvecCours>();
        }
        public string Nom { get; set; }
        public virtual ICollection<PartcipationDTOAvecCours> Participation { get; set; }
    }


    public partial class EtudiantDTOIN
    {
        public EtudiantDTOIN()
        {
        }

        // les données présentes dans la tables uniquement
        public int IdEtudiant { get; set; }
        public string Nom { get; set; }
        public int IdGrade { get; set; }
    }

    public class EtudiantDTOAvecGrade
    {           
        public string Nom { get; set; }
           

    }
}
