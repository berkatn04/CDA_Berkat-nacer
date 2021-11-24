using GestionEmploye.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEmploye.Data.Profile
{
    public class ProfileEmploye
    {
        CreateMap<Employe, EmployeDTO>();
        CreateMap<EmployeDTO, Employe>();
    }
}
