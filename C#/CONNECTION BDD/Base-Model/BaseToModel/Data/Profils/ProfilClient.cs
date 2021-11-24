using AutoMapper;
using BaseToModel.Data.DTO;
using BaseToModel.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseToModel.Data.Profils
{
    public class ProfilClient : Profile
    {
        public ProfilClient()
        {
            CreateMap<Client, ClientDTO>();
            CreateMap<ClientDTO, Client>();
        }
    }
}
