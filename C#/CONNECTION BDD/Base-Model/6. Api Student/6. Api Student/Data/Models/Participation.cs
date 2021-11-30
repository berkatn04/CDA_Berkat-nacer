using System;
using System.Collections.Generic;

#nullable disable

namespace _6._Api_Student.Data.Models
{
    public partial class Participation
    {
        public int IdParticipation { get; set; }
        public int? IdStudent { get; set; }
        public int? IdCourse { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
