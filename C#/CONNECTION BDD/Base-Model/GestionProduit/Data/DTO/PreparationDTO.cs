using GestionProduit.Data.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace GestionProduit.Data.DTO
{
    public partial class PreparationDTOOUT
    {
       
        public int IdCommande { get; set; }
        public int IdProduit { get; set; }
    }

    public partial class PreparationDTOIN
    {
        public int IdPreparation { get; set; }
        public int IdCommande { get; set; }
        public int IdProduit { get; set; }
    }

    public partial class PreparationProduitDTO
    {
        public ProduitDTOOUT Produit { get; set; }
    }
}
