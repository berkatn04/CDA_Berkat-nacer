using GestionProduit.Data.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace GestionProduit.Data.DTO
{
    public partial class CommandeDTOOUT
    {
        
        public int IdCommande { get; set; }
        public string Description { get; set; }
      
    }
}
