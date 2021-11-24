using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using voiture.Data.Dto;
using voiture.Data.Models;
using voiture.Data.Services;
//using voiture.Helpers;

namespace voiture.Controllers
{
    [Route("api/Voitures")]
    [ApiController]


    public class VoitureController : ControllerBase
    {
        private readonly VoitureService _service;
        private readonly IMapper _mapper;

        public VoitureController(VoitureService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Voiture>> GetAllVoiture()
        {

            IEnumerable<Voiture> listeVoitures = _service.GetAllVoiture();
            return Ok(_mapper.Map<IEnumerable<VoitureDTO>>(listeVoitures));
        }
        
    }
}
