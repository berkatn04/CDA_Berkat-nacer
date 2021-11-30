using _6._Api_Student.Data.Dtos;
using _6._Api_Student.Data.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6._Api_Student.Data.Profiles
{
    public class CoursesProfile : Profile
    {
        public CoursesProfile()
        {
            CreateMap<Course, CoursesDTOIn>();
            CreateMap<CoursesDTOIn, Course>();
            CreateMap<Course, CoursesDTOOut>();
            CreateMap<CoursesDTOOut, Course>();
        }
    }
}
