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
    public class EtudiantsController : ControllerBase
    {

        private readonly EtudiantsService _service;
        private readonly IMapper _mapper;

        public EtudiantsController(EtudiantsService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Etudiants
        [HttpGet]
        public ActionResult<IEnumerable<EtudiantDTO>> GetAllEtudiants()
        {
            IEnumerable<Etudiant> listeEtudiants = _service.GetAllEtudiants();
            return Ok(_mapper.Map<IEnumerable<EtudiantDTO>>(listeEtudiants));
        }

        //GET api/Etudiants/{i}
        [HttpGet("{id}", Name = "GetEtudiantById")]
        public ActionResult<EtudiantDTO> GetEtudiantById(int id)
        {
            Etudiant commandItem = _service.GetEtudiantById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<EtudiantDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/Etudiants
        [HttpPost]
        public ActionResult<EtudiantDTO> CreateEtudiant(EtudiantDTOIN obj)
        {
            _service.AddEtudiant(_mapper.Map<Etudiant>(obj));
            return CreatedAtRoute(nameof(GetEtudiantById), new { Id = obj.IdEtudiant }, obj);
        }

        //POST api/Etudiants/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateEtudiant(int id, EtudiantDTOIN obj)
        {
            Etudiant objFromRepo = _service.GetEtudiantById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateEtudiant(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Etudiants/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialEtudiantUpdate(int id, JsonPatchDocument<Etudiant> patchDoc)
        {
            Etudiant objFromRepo = _service.GetEtudiantById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Etudiant objToPatch = _mapper.Map<Etudiant>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateEtudiant(objFromRepo);
            return NoContent();
        }

        //DELETE api/Etudiants/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteEtudiant(int id)
        {
            Etudiant obj = _service.GetEtudiantById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteEtudiant(obj);
            return NoContent();
        }


    }
}
