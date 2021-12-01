using System;
using System.Collections.Generic;

#nullable disable

namespace GestionStock.Data.Models
{
    public partial class TypeProduits
    {
        public TypeProduits()
        {
            Categorie = new HashSet<Categories>();
        }

        public int IdTypeProduits { get; set; }
        public string LibelleTypeProduit { get; set; }

        public virtual ICollection<Categories> Categorie { get; set; }
    }
}
