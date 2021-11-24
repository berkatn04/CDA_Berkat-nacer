using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BaseToModel;
using BaseToModel.Data.Models;
using BaseToModel.Data.Services;
using AutoMapper;
using BaseToModel.Data.DTO;

namespace BaseToModel.Controllers
{
    [Route("api/Client")]
    [ApiController]

    public class ControllerClient : ControllerBase
    {
        private readonly ServiceClient _service;
        private readonly IMapper _mapper;


        public ControllerClient(ServiceClient service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Client>> GetAllClient()
        {

            IEnumerable<Client> listeClient = _service.GetAllClient();
            return Ok(_mapper.Map<IEnumerable<ClientDTO>>(listeClient));
        }
    }
}
