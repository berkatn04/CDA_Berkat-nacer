using AutoMapper;
using GestionProduit.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduit.Data.Profiles
{
    public class PreparationProfile : Profile
    {
        public PreparationProfile()
        {
            CreateMap<Preparation, PreparationDTOOUT>();
            CreateMap<PreparationDTOOUT, Preparation>();
            CreateMap<Preparation, PreparationProduitDTO>();
            CreateMap<PreparationProduitDTO, Preparation>();
        }
    }
}
