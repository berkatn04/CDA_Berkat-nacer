using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesStocks.Data.Models
{
    public partial class Articles
    {
        public int IdArticle { get; set; }
        public string LibelleArticle { get; set; }
        public int? QuantiteStockee { get; set; }
        public int IdCategories { get; set; }

        public virtual Categories Categorie { get; set; }
    }
}
