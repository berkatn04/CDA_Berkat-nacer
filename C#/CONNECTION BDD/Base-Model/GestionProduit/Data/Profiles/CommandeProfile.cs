using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GestionProduit.Data.Models;
using GestionProduit.Data.DTO;

namespace GestionProduit.Data.Profiles
{
    public class CommandeProfile: Profile
    {
        public CommandeProfile()
        {
            CreateMap<Commande, CommandeDTOOUT>();
            CreateMap<CommandeDTOIN, Commande>();
            CreateMap<Commande, CommandeDTOIN>();
            CreateMap<CommandeDTOOUT, Commande>();       
            CreateMap<Commande, CommandeAvecProduitDTO>();
            CreateMap<CommandeAvecProduitDTO, Commande>();
        
}
    }
}
