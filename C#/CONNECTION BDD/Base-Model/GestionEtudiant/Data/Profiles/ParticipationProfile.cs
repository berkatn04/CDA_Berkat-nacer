using AutoMapper;
using GestionEtudiant.Data.DTO;
using GestionEtudiant.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiant.Data.Profiles
{
    public class ParticipationProfile : Profile
    {
        public ParticipationProfile()
        {

            //CreateMap<StudentCourse, StudentCourseDTOIn>();
            //CreateMap<StudentCourseDTOIn, StudentCourse>();

            //CreateMap<StudentCourse, StudentCourseDTOOut>();
            CreateMap<Participation, ParticipationAvecEtudiant>();
            //CreateMap<StudentCourseDTOOut, StudentCourse>();
            CreateMap<ParticipationAvecEtudiant, Participation>();
        }
    }
}
