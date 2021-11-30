using AutoMapper;
using GestionEtudiant.Data.DTO;
using GestionEtudiant.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiant.Data.Profiles
{
    public class EtudiantsProfile : Profile
    {
        public EtudiantsProfile()
        {

            CreateMap<Etudiant, EtudiantDTO>();
            CreateMap<EtudiantDTOIN, Etudiant>();
            CreateMap<Etudiant, EtudiantDTOAvecGrade>();
            CreateMap<EtudiantDTOAvecGrade, Etudiant>();
            CreateMap<Etudiant, EtudiantDTO>();
            CreateMap<EtudiantDTO, Etudiant>();
        }
    }
}
