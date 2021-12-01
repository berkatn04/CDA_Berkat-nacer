
using System;
using System.Collections.Generic;

#nullable disable

namespace GestionStock.Data.DTOS
{
    public partial class CategoriesDTOOUT
    {
       
        public int IdCategories { get; set; }
        public string LibelleCategorie { get; set; }
        public int IdTypeProduits { get; set; }
     
    }
}
