using _6._Api_Student.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6._Api_Student.Data.Dtos
{
    public class CoursesDTOIn
    {
        public string NomCourse { get; set; }
        public string DescriptionCourse { get; set; }

    }
    public class CoursesDTOOut
    {
        public CoursesDTOOut()
        {
            ListParticipation = new HashSet<ParticipationDTOStudents>();
        }

        public string NomCourse { get; set; }
        public string DescriptionCourse { get; set; }

        public virtual ICollection<ParticipationDTOStudents> ListParticipation { get; set; }
    }
}
