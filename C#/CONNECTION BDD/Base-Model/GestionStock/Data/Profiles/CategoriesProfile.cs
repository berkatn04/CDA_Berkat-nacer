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
    class CategoriesProfile : Profile
    {
        public CategoriesProfile()
        {
            CreateMap<Categories, CategoriesDTOOUT>();
            CreateMap<CategoriesDTOOUT, Categories>();
        }
    }
}
