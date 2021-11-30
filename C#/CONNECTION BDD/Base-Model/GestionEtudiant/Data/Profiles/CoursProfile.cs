using AutoMapper;
using GestionEtudiant.Data.DTO;
using GestionEtudiant.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiant.Data.Profiles
{
    public class CoursProfile: Profile
    {
        public CoursProfile()
        {
            CreateMap<Cour, CourDTOIn>();
            CreateMap<CourDTOIn, Cour>();

            CreateMap<Cour, CourDTO>();
            CreateMap<Cour, CourDTOAvecParticipation>();
            CreateMap<CourDTO, Cour>();
            CreateMap<CourDTOAvecParticipation, Cour>();
        }
    }
}
