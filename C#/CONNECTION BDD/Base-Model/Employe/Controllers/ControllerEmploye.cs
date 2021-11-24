using AutoMapper;
using GestionEmploye.Data.DTO;
using GestionEmploye.Data.Models;
using GestionEmploye.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEmploye.Controllers
{
    [Route("api/Employe")]
    [ApiController]

    public class ControllerEmploye : ControllerBase
    {
        private readonly ServiceEmploye _service;
        private readonly IMapper _mapper;


        public ControllerEmploye(ServiceEmploye service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employes>> GetAllVoiture()
        {

            IEnumerable<Employes> listeEmploye = _service.GetAllEmploye();
            return Ok(_mapper.Map<IEnumerable<EmployeDTO>>(listeEmploye));
        }






    }

    
}
