using AutoMapper;
using GestionEtudiant.Data.DTO;
using GestionEtudiant.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiant.Data.Profiles
{
    public class GradesProfile : Profile
    {
        public GradesProfile()
        {

            CreateMap<Grade, GradeDTOIn>();
            CreateMap<GradeDTOIn, Grade>();

            CreateMap<Grade, GradeDTO>();
            CreateMap<Grade, GradeDTOAvecEtudiant>();
            CreateMap<GradeDTO, Grade>();
            CreateMap<GradeDTOAvecEtudiant, Grade>();
        }
    }
}
