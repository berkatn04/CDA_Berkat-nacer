﻿using System;
using System.Collections.Generic;

#nullable disable

namespace VillageGreen.Data.Models.Dtos
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public int IdRole { get; set; }
        public string LibelleRole { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
