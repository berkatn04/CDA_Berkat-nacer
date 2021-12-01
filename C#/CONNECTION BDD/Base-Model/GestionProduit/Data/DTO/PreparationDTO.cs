using GestionProduit.Data.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace GestionProduit.Data.DTO
{
    public partial class PreparationDTOOUT
    {
        public int IdPreparation { get; set; }
        public int IdCommande { get; set; }
        public int IdProduit { get; set; }
    }
}
