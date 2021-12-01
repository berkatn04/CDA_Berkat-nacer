using System;
using System.Collections.Generic;

#nullable disable

namespace GestionStock.Data.DTOS
{
    public partial class ArticlesDTOOUT
    {
        public int IdArticle { get; set; }
        public string LibelleArticle { get; set; }
        public int? QuantiteStockee { get; set; }
        public int IdCategories { get; set; }
    }
}
