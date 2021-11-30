using AutoMapper;
using GestionEtudiant.Data.DTO;
using GestionEtudiant.Data.Models;
using GestionEtudiant.Data.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipationsController : ControllerBase
    {


        private readonly ParticipationsService _service;
        private readonly IMapper _mapper;

        public ParticipationsController(ParticipationsService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PartcipationDTOAvecEtudiantEtCours>> GetAllParticipations()
        {
            IEnumerable<Participation> listeParticipation  = _service.GetAllParticipations();
            return Ok(_mapper.Map<IEnumerable<PartcipationDTOAvecEtudiantEtCours>>(listeParticipation));
        }

        
        [HttpGet("{id}", Name = "GetParticipationById")]
        public ActionResult<PartcipationDTOAvecEtudiantEtCours> GetParticipationById(int id)
        {
            Participation commandItem = _service.GetParticipationById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<PartcipationDTOAvecEtudiantEtCours>(commandItem));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<ParticipationDTOAvecEtudiant> CreateParticipation(Participation obj)
        {
            _service.AddParticipation(obj);
            return CreatedAtRoute(nameof(GetParticipationById), new { Id = obj.IdParticipation }, obj);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateNomModel(int id, ParticipationDTOIN obj)
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
        //PATCH api/NomModels/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialNomModelUpdate(int id, JsonPatchDocument<Participation> patchDoc)
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

        //DELETE api/NomModels/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteNomModel(int id)
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
