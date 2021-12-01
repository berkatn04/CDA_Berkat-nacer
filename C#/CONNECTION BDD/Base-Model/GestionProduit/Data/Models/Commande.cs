using GestionProduit.Data.DTO;
using System;
using System.Collections.Generic;

#nullable disable

namespace GestionProduit.Data.Models
{
    public partial class Commande
    {
        public Commande()
        {
            Preparations = new HashSet<Preparation>();
        }

        public int IdCommande { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Preparation> Preparations { get; set; }
    }
}
