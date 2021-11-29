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
    [Route("api/Villes")]
    [ApiController]
    public class VilleController : ControllerBase
    {
        private readonly VilleService _service;
        private readonly IMapper _mapper;

        public VilleController(VilleService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Entite2
        [HttpGet]
        public ActionResult<IEnumerable<VilleDTO>> GetAllEntite2()
        {
            IEnumerable<Villes> listeVille = _service.GetAllVille();
            return Ok(_mapper.Map<IEnumerable<VilleDTO>>(listeVille));
        }
    }
}
