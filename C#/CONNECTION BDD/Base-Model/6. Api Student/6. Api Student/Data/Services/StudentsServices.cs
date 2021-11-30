using _6._Api_Student.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6._Api_Student.Data.Services
{
    public class StudentsServices
    {

        private readonly StudentContext _context;

        public StudentsServices(StudentContext context)
        {
            _context = context;
        }

        public void AddStudent(Student obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Students.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteStudent(Student obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Students.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students.Include("ListParticipation.Course").ToList();
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.Include("ListParticipation.Course").FirstOrDefault(obj => obj.IdStudent == id);
        }

        public void UpdateStudent(Student obj)
        {
            _context.SaveChanges();
        }


    }
}
