using System;
using System.Collections.Generic;

#nullable disable

namespace _6._Api_Student.Data.Models
{
    public partial class Student
    {
        public Student()
        {
            ListParticipation = new HashSet<Participation>();
        }

        public int IdStudent { get; set; }
        public string NomStudent { get; set; }
        public int? AgeStudent { get; set; }

        public virtual ICollection<Participation> ListParticipation { get; set; }
    }
}
