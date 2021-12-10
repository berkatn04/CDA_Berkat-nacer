using System;
using System.Collections.Generic;

#nullable disable

namespace VillageGreen.Data.Models.Dtos
{
    public partial class ApprovisionnementDTOOut
    {
        public int IdApprovisionnement { get; set; }
        public int? IdProduit { get; set; }
        public int? IdFournisseur { get; set; }
        public string RefFournisseur { get; set; }
        public string LibelleProduit { get; set; }
        public string NomFournisseur { get; set; }
    }

    public partial class ApprovisionnementDTOIn
    {
        public int? IdProduit { get; set; }
        public int? IdFournisseur { get; set; }
        public string RefFournisseur { get; set; }
    }

}
