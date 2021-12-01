using System;
using System.Collections.Generic;

#nullable disable

namespace GestionProduit.Data.DTO
{
    public partial class ProduitDTOOUT
    {                   
        public string LibelleProduit { get; set; }       
    }

    public partial class ProduitDTOIN
    {
        public int IdProduit { get; set; }
        public string LibelleProduit { get; set; }

    }
}
