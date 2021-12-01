using AutoMapper;
using GestionProduit.Data.DTO;
using GestionProduit.Data.Models;
using GestionProduit.Data.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreparationController : ControllerBase
    {

        private readonly PreparationService _service;
        private readonly IMapper _mapper;

        public PreparationController(PreparationService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Preparations
        [HttpGet]
        public ActionResult<IEnumerable<PreparationDTOOUT>> GetAllPreparations()
        {
            IEnumerable<Preparation> listePreparations = _service.GetAllPreparations();
            return Ok(_mapper.Map<IEnumerable<PreparationDTOOUT>>(listePreparations));
        }

        //GET api/Preparations/{i}
        [HttpGet("{id}", Name = "GetPreparationById")]
        public ActionResult<PreparationDTOOUT> GetPreparationById(int id)
        {
            Preparation commandItem = _service.GetPreparationById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<PreparationDTOOUT>(commandItem));
            }
            return NotFound();
        }

        //POST api/Preparations
        [HttpPost]
        public ActionResult<PreparationDTOOUT> CreatePreparation(Preparation obj)
        {
            _service.AddPreparation(obj);
            return CreatedAtRoute(nameof(GetPreparationById), new { Id = obj.IdPreparation }, obj);
        }

        //POST api/Preparations/{id}
        [HttpPut("{id}")]
        public ActionResult UpdatePreparation(int id, PreparationDTOOUT obj)
        {
            Preparation objFromRepo = _service.GetPreparationById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdatePreparation(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Preparations/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialPreparationUpdate(int id, JsonPatchDocument<Preparation> patchDoc)
        {
            Preparation objFromRepo = _service.GetPreparationById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Preparation objToPatch = _mapper.Map<Preparation>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdatePreparation(objFromRepo);
            return NoContent();
        }

        //DELETE api/Preparations/{id}
        [HttpDelete("{id}")]
        public ActionResult DeletePreparation(int id)
        {
            Preparation obj = _service.GetPreparationById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeletePreparation(obj);
            return NoContent();
        }


    }
}
