using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TableLiée.Data.DTO;
using TableLiée.Data.Models;
using TableLiée.Data.Services;

namespace TableLiée.Controllers
{

    [Route("api/Departement")]
    [ApiController]
    public class DepartementController : ControllerBase
    {
        private readonly DepartementService _service;
        private readonly IMapper _mapper;

        public DepartementController(DepartementService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DepartementDTO>> GetAllDepartement()
        {
            IEnumerable<Departements> listeDepartement = _service.GetAllDepartement();
            return Ok(_mapper.Map<IEnumerable<DepartementDTO>>(listeDepartement));
        }
        /*
        [HttpGet("{id}", Name = "GetEntite1ById")]
        public ActionResult<DepartementDTO> GetEntite1ById(int id)
        {
            Departements ent = _service.GetDepartementById(id);
            return Ok(_mapper.Map<DepartementDTO>(ent));
        }
        */
    }
}
