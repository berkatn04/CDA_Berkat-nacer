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

            CreateMap<Participation, ParticipationDTOIN>();
            CreateMap<ParticipationDTOIN, Participation>();

            CreateMap<Participation, PartcipationDTOAvecEtudiantEtCours>();
            CreateMap<PartcipationDTOAvecEtudiantEtCours, Participation>();

            CreateMap<Participation, PartcipationDTOAvecCours>();
            CreateMap<PartcipationDTOAvecCours, Participation>();

            CreateMap<Participation, ParticipationDTO>();
            CreateMap<ParticipationDTO, Participation>();

            CreateMap<Participation, ParticipationDTOAvecEtudiant>();
            CreateMap<ParticipationDTOAvecEtudiant, Participation>();
        }

        }
    }
