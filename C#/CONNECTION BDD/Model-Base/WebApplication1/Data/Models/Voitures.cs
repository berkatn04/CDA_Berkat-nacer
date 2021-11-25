﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data.Models
{
    public class Voitures
    {
        [Key]
        public int IdVoiture { get; set; }

        [MaxLength(50)]
        public string Marque { get; set; }

        [MaxLength(50)]
        public string Modele { get; set; }
        
    }
}
