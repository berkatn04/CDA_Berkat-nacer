using GestionStock.Data.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace GestionStock.Data.DTOS
{
    public partial class TypeProduitsDTOOUT
    {      
        public int IdTypeProduits { get; set; }
        public string LibelleTypeProduit { get; set; }
       
    }
}
