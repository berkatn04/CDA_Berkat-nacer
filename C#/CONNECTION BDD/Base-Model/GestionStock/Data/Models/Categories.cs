using System;
using System.Collections.Generic;

#nullable disable

namespace GestionStock.Data.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Article = new HashSet<Articles>();
        }

        public int IdCategories { get; set; }
        public string LibelleCategorie { get; set; }
        public int IdTypeProduits { get; set; }

        public virtual TypeProduits  TypeProduit { get; set; }
        public virtual ICollection<Articles> Article { get; set; }
    }
}
