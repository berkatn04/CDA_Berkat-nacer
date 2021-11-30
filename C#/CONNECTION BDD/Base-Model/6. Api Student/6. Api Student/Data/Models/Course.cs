using System;
using System.Collections.Generic;

#nullable disable

namespace _6._Api_Student.Data.Models
{
    public partial class Course
    {
        public Course()
        {
            ListParticipation = new HashSet<Participation>();
        }

        public int IdCourse { get; set; }
        public string NomCourse { get; set; }
        public string DescriptionCourse { get; set; }

        public virtual ICollection<Participation> ListParticipation { get; set; }
    }
}
