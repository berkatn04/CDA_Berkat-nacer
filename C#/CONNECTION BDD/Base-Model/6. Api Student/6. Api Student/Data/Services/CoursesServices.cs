using _6._Api_Student.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6._Api_Student.Data.Services
{
    public class CoursesServices
    {

        private readonly StudentContext _context;

        public CoursesServices(StudentContext context)
        {
            _context = context;
        }

        public void AddCourse(Course obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Courses.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteCourse(Course obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Courses.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _context.Courses.Include("ListParticipation.Student").ToList();
        }

        public Course GetCourseById(int id)
        {
            return _context.Courses.Include("ListParticipation.Student").FirstOrDefault(obj => obj.IdCourse == id);
        }

        public void UpdateCourse(Course obj)
        {
            _context.SaveChanges();
        }


    }
}
