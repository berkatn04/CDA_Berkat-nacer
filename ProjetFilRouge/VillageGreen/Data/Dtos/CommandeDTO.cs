using System;
using System.Collections.Generic;

#nullable disable

namespace VillageGreen.Data.Models.Dtos
{
    public partial class CommandeDTOOut
    {

        public int IdCommande { get; set; }
        public string NumeroCommande { get; set; }
        public DateTime? DateCommande { get; set; }
        public int IdUser { get; set; }
        public int IdAdresse { get; set; }
        public string  AdressePostale { get; set; }
        public string  RefClient { get; set; }
        public int IdCategorieClient { get; set; }
        public string InfoReglement { get; set; }
        public string Province { get; set; }
        public string ComplementAdresse { get; set; }
        public int IdVille { get; set; }
        public string CodePostal { get; set; }
    }

    public partial class CommandeDTOIn
    {
        public string NumeroCommande { get; set; }
        public DateTime DateCommande { get; set; }
        public int IdUser { get; set; }
        public int IdAdresse { get; set; }
    }
}
