using AutoMapper;
using GestionEtudiant.Data.DTO;
using GestionEtudiant.Data.Models;
using GestionEtudiant.Data.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
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
    public class CoursController : ControllerBase
    {

        private readonly CoursService _service;
        private readonly IMapper _mapper;

        public CoursController(CoursService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Cours
        [HttpGet]
        public ActionResult<IEnumerable<CourDTO>> GetAllCours()
        {
            IEnumerable<Cour> listeCours = _service.GetAllCours();
            return Ok(_mapper.Map<IEnumerable<CourDTO>>(listeCours));
        }

        //GET api/Cours/{i}
        [HttpGet("{id}", Name = "GetCourById")]
        public ActionResult<CourDTO> GetCourById(int id)
        {
            Cour commandItem = _service.GetCoursById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<CourDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/Cours
        [HttpPost]
        public ActionResult<CourDTO> CreateCour(CourDTOIn obj)
        {
            _service.AddCour(_mapper.Map<Cour>(obj));
            return CreatedAtRoute(nameof(GetCourById), new { Id = obj.IdCours }, obj);
        }

        //POST api/Cours/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateCour(int id, CourDTO obj)
        {
            Cour objFromRepo = _service.GetCoursById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateCours(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Cours/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialCourUpdate(int id, JsonPatchDocument<Cour> patchDoc)
        {
            Cour objFromRepo = _service.GetCoursById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Cour objToPatch = _mapper.Map<Cour>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateCours(objFromRepo);
            return NoContent();
        }

        //DELETE api/Cours/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCour(int id)
        {
            Cour obj = _service.GetCoursById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteCours(obj);
            return NoContent();
        }


    }
}
