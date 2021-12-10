using System;
using System.Collections.Generic;

#nullable disable

namespace VillageGreen.Data.Models.Dtos
{
    public partial class AdresseDTOIn
    {
        
        public string EmailAdresse { get; set; }
        public string TelMobile { get; set; }
        public string TelFixe { get; set; }
        public string AdressePostale { get; set; }
        public string Province { get; set; }
        public string ComplementAdresse { get; set; }
        public int IdVille { get; set; }
        public int IdPays { get; set; }

    }

    public partial class AdresseDTOOout
    {
        public int IdAdresse { get; set; }
        public string EmailAdresse { get; set; }
        public string TelMobile { get; set; }
        public string TelFixe { get; set; }
        public string AdressePostale { get; set; }
        public string Province { get; set; }
        public string ComplementAdresse { get; set; }
        public int IdVille { get; set; }
        public string LibelleVille { get; set; }
        public int IdPays { get; set; }
        public string NomPays { get; set; }

    }
}
