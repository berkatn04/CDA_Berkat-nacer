using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GestionStock.Data.DTOS;
using GestionStock.Data.Models;

namespace GestionStock.Data.Profiles
{
    class ArticlesProfile : Profile
    {
        public ArticlesProfile()
        {
            CreateMap<Articles , ArticlesDTOOUT>();
            CreateMap<ArticlesDTOOUT, Articles>();
        }
    }
}
