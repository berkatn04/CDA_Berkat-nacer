using AutoMapper;
using GestionDesStocks.Data.DTOS;
using GestionDesStocks.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesStocks.Data.Profiles
{
    class TypeProduitsProfile : Profile
    {
        public TypeProduitsProfile()
        {
            CreateMap<TypeProduits, TypeProduitsDTOOUT>();
            CreateMap<TypeProduitsDTOOUT, TypeProduits>();
        }
    }
}
