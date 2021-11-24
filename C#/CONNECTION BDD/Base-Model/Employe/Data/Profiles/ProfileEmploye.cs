using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionEmploye.Data.DTO;
using GestionEmploye.Models;
using GestionEmploye.Data.Models;

namespace GestionEmploye.Data.Profiles
{
    public class ProfileEmploye : Profile
    {
        public ProfileEmploye()
        {
            CreateMap<Employes, EmployeDTO>();
            CreateMap<EmployeDTO, Employes>();
        }
       
    }
}
