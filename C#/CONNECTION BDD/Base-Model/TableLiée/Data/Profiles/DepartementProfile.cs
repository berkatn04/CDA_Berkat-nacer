using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TableLiée.Data.DTO;
using TableLiée.Data.Models;

namespace TableLiée.Data.Profiles
{
    public class DepartementProfile : Profile
    {
        public DepartementProfile()
        {
            CreateMap<DepartementDTO, Departements>();
            CreateMap<Departements, DepartementDTO>();

        }
    }
}
