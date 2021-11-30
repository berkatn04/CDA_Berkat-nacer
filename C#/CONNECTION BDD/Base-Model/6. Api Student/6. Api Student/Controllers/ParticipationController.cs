using _6._Api_Student.Data.Dtos;
using _6._Api_Student.Data.Models;
using _6._Api_Student.Data.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6._Api_Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipationController : Controller
    {

        private readonly ParticipationServices _service;
        private readonly IMapper _mapper;

        public ParticipationController(ParticipationServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Participation
        [HttpGet]
        public ActionResult<IEnumerable<ParticipationDTOOut>> GetAllParticipation()
        {
            IEnumerable<Participation> listeParticipation = _service.GetAllParticipation();
            return Ok(_mapper.Map<IEnumerable<ParticipationDTOOut>>(listeParticipation));
        }

        //GET api/Participation/{i}
        [HttpGet("{id}", Name = "GetParticipationById")]
        public ActionResult<ParticipationDTOOut> GetParticipationById(int id)
        {
            Participation commandItem = _service.GetParticipationById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<ParticipationDTOOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/Participation
        [HttpPost]
        public ActionResult<ParticipationDTOIn> CreateParticipation(ParticipationDTOIn objIn)
        {
            Participation obj = _mapper.Map<Participation>(objIn);
            _service.AddParticipation(obj);
            return CreatedAtRoute(nameof(GetParticipationById), new { Id = obj.IdParticipation }, obj);
        }

        //POST api/Participation/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateParticipation(int id, ParticipationDTOIn obj)
        {
            Participation objFromRepo = _service.GetParticipationById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateParticipation(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Participation/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialParticipationUpdate(int id, JsonPatchDocument<Participation> patchDoc)
        {
            Participation objFromRepo = _service.GetParticipationById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Participation objToPatch = _mapper.Map<Participation>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateParticipation(objFromRepo);
            return NoContent();
        }

        //DELETE api/Participation/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteParticipation(int id)
        {
            Participation obj = _service.GetParticipationById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteParticipation(obj);
            return NoContent();
        }

    }
}
