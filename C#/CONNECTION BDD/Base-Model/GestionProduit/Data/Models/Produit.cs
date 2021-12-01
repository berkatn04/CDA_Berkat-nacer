using GestionProduit.Data.DTO;
using System;
using System.Collections.Generic;

#nullable disable

namespace GestionProduit.Data.Models
{
    public partial class Produit
    {
        public Produit()
        {
            Preparation = new HashSet<Preparation>();
        }

        public int IdProduit { get; set; }
        public string LibelleProduit { get; set; }

        public virtual ICollection<Preparation> Preparation { get; set; }
    }
}
