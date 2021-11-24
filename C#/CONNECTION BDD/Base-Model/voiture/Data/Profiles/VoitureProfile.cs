using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using voiture.Data.Dto;
using voiture.Data.Models;

namespace voiture.Data.Profiles
{
    public class VoitureProfile : Profile
    {

        public VoitureProfile()
        {
            CreateMap<Voiture, VoitureDTO>();
            CreateMap<VoitureDTO, Voiture>();

        }

    }
}
