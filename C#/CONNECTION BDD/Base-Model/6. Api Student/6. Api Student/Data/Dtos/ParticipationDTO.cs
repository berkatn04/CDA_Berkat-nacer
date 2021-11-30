using _6._Api_Student.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6._Api_Student.Data.Dtos
{
    public class ParticipationDTOIn
    {
        public int? IdStudent { get; set; }
        public int? IdCourse { get; set; }
    }
    public class ParticipationDTOOut
    {
        public virtual CoursesDTOIn Course { get; set; }
        public virtual StudentsDTOIn Student { get; set; }
    }
    public class ParticipationDTOStudents
    {
        public virtual StudentsDTOIn Student { get; set; }
    }

    public class ParticipationDTOCourses
    {
        public virtual CoursesDTOIn Course { get; set; }
    }
}
