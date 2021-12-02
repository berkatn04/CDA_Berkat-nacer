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
    class CategoriesProfile : Profile
    {
        public CategoriesProfile()
        {
            CreateMap<Categories, CategoriesDTOOUT>();
            CreateMap<CategoriesDTOOUT, Categories>();
        }
    }
}
