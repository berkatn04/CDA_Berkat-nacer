using System;
using System.Collections.Generic;

#nullable disable

namespace VillageGreen.Data.Models.Dtos
{
    public partial class ClientDTOOut
    {
        public int IdUser { get; set; }
        public string RefClient { get; set; }
        public int CoefClient { get; set; }
        public int IdCategorieClient { get; set; }
        public string LibelleCategClient { get; set; }
    }

    public partial class ClientDTOIn
    {
        public int IdUser { get; set; }
        public string RefClient { get; set; }
        public int CoefClient { get; set; }
        public int IdCategorieClient { get; set; }
    }
}
