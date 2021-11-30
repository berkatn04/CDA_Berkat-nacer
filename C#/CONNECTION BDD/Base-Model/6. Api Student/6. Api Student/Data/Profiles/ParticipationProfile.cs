using _6._Api_Student.Data.Dtos;
using _6._Api_Student.Data.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6._Api_Student.Data.Profiles
{
    public class ParticipationProfile : Profile
    {
        public ParticipationProfile()
        {
            CreateMap<Participation, ParticipationDTOIn>();
            CreateMap<ParticipationDTOIn, Participation>();
            CreateMap<Participation, ParticipationDTOOut>();
            CreateMap<ParticipationDTOOut, Participation>();
            CreateMap<Participation, ParticipationDTOStudents>();
            CreateMap<ParticipationDTOStudents, Participation>();
            CreateMap<Participation, ParticipationDTOCourses>();
            CreateMap<ParticipationDTOCourses, Participation>();
        }
    }
}
