using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Dtos;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Profiles
{
    public class PersonnesProfile : Profile
    {
        public PersonnesProfile()
        {
            CreateMap<Personne, PersonneDTO>();
            CreateMap<PersonneDTO, Personne>();
        }
    }
}
