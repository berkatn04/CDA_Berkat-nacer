using AutoMapper;
using GestionStock.Data.DTOS;
using GestionStock.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Data.Profiles
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
