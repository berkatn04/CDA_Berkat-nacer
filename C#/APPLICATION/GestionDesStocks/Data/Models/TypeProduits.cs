using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesStocks.Data.Models
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
