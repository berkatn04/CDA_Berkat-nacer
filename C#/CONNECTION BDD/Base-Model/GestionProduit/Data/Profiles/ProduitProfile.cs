using AutoMapper;
using GestionProduit.Data.DTO;
using GestionProduit.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduit.Data.Profiles
{
    public class ProduitProfile : Profile
    {
        public ProduitProfile()
        {
            CreateMap<Produit, ProduitDTOOUT>();
            CreateMap<ProduitDTOOUT, Produit>();
        }
    }
}
