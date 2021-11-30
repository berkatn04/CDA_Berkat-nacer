using _6._Api_Student.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6._Api_Student.Data.Dtos
{
    public class StudentsDTOIn
    {
        public string NomStudent { get; set; }
        public int? AgeStudent { get; set; }
    }
    public class StudentsDTOOut
    {
        public StudentsDTOOut()
        {
            ListParticipation = new HashSet<ParticipationDTOCourses>();
        }

        public string NomStudent { get; set; }
        public int? AgeStudent { get; set; }

        public virtual ICollection<ParticipationDTOCourses> ListParticipation { get; set; }
    }
}
