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
    class ArticlesProfile : Profile
    {
        public ArticlesProfile()
        {
            CreateMap<Articles, ArticlesDTOOUT>();
            CreateMap<ArticlesDTOOUT, Articles>();
        }
    }
}
