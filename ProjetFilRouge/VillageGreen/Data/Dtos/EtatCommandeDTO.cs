using System;
using System.Collections.Generic;

#nullable disable

namespace VillageGreen.Data.Models.Dtos
{
    public partial class EtatCommande
    {
       

        public int IdEtatCommande { get; set; }
        public string LibelleEtatCommande { get; set; }

        public virtual ICollection<ProgressionCommande> ProgressionsCommande { get; set; }
    }
}
