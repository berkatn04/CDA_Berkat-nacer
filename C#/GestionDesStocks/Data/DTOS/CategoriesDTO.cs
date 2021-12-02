using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesStocks.Data.DTOS
{
    public partial class CategoriesDTOOUT
    {

        public int IdCategories { get; set; }
        public string LibelleCategorie { get; set; }
        public int IdTypeProduits { get; set; }

    }
}
