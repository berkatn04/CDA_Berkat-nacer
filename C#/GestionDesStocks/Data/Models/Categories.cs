using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesStocks.Data.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Articles = new HashSet<Articles>();
        }

        public int IdCategories { get; set; }
        public string LibelleCategorie { get; set; }
        public int IdTypeProduits { get; set; }

        public virtual TypeProduits TypeProduit { get; set; }
        public virtual ICollection<Articles> Articles { get; set; }
    }
}
