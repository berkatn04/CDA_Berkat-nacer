using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelToBase.Data
{
    public class Comptes
    {
        [Key]
        public int IdComptes { get; set; }


        public int solde { get; set; }


        public int Code { get; set; }
    }
}
