using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiant.Data.DTO
{
    public class GradeDTO
    {
        public GradeDTO()
        {
        }

        public string NomGrade { get; set; }

    }

    public partial class GradeDTOIn
    {
        public GradeDTOIn()
        {
        }

        public int IdGrade { get; set; }
        public string NomGrade { get; set; }

    }

    public class GradeDTOAvecEtudiant
    {
        public GradeDTOAvecEtudiant()
        {
            Etudiants = new HashSet<EtudiantDTO>();
        }

        public string NomGrade { get; set; }

        public virtual ICollection<EtudiantDTO> Etudiants { get; set; }
    }

}
