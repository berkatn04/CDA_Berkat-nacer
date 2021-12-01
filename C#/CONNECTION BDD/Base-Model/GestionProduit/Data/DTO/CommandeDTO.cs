using GestionProduit.Data.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace GestionProduit.Data.DTO
{
    public partial class CommandeDTOOUT
    {
        
        public string Description { get; set; }
      
    }

    public partial class CommandeDTOIN
    {

        public int IdCommande { get; set; }
        public string Description { get; set; }

    }

    public partial class CommandeAvecProduitDTO
    {        
        public string Description { get; set; }
        public virtual ICollection<PreparationProduitDTO> Preparation { get; set; }

    }

}
