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

        }
        public string NomEtudiant { get; set; }
    }


    public partial class EtudiantDTOIN
    {
        public EtudiantDTOIN()
        {
        }

        // les données présentes dans la tables uniquement
        public int IdEtudiant { get; set; }
        public string NomEtudiant { get; set; }
        public int IdGrade { get; set; }
    }

    public class EtudiantDTOAvecGrade
    {
        public EtudiantDTOAvecGrade()
        {
        }
        // les colonnes de la table sans les id
        public string NomGrade { get; set; }
        public int IdGrade { get; set; }

        // ajouter les données attachées
        // ATTENTION il faut retourner un DTOOut
        public virtual GradeDTO Grade { get; set; }

    }
}
