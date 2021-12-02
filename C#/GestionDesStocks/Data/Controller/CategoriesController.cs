using AutoMapper;
using GestionDesStocks.Data.DTOS;
using GestionDesStocks.Data.Models;
using GestionDesStocks.Data.Profiles;
using GestionDesStocks.Data.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesStocks.Data.Controller
{
    class CategoriesController : ControllerBase
    {

        private readonly CategoriesService _service;
        private readonly IMapper _mapper;

        public CategoriesController(CategoriesService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public CategoriesController(MyDbContext _context)
        {
            _service = new CategoriesService(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CategoriesProfile>();
            });
            _mapper = config.CreateMapper();
        }

        //GET api/Categories
        [HttpGet]
        public ActionResult<IEnumerable<CategoriesDTOOUT>> GetAllCategories()
        {
            IEnumerable<Categories> listeCategories = _service.GetAllCategories();
            return Ok(_mapper.Map<IEnumerable<CategoriesDTOOUT>>(listeCategories));
        }

        //GET api/Categories/{i}
        [HttpGet("{id}", Name = "GetCategorieById")]
        public ActionResult<CategoriesDTOOUT> GetCategorieById(int id)
        {
            Categories commandItem = _service.GetCategoriesById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<CategoriesDTOOUT>(commandItem));
            }
            return NotFound();
        }

        //POST api/Categories
        [HttpPost]
        public ActionResult<CategoriesDTOOUT> CreateCategorie(Categories obj)
        {
            _service.AddCategories(obj);
            return CreatedAtRoute(nameof(GetCategorieById), new { Id = obj.IdCategories }, obj);
        }

        //POST api/Categories/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateCategorie(int id, CategoriesDTOOUT obj)
        {
            Categories objFromRepo = _service.GetCategoriesById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateCategories(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Categories/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialCategorieUpdate(int id, JsonPatchDocument<Categories> patchDoc)
        {
            Categories objFromRepo = _service.GetCategoriesById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Categories objToPatch = _mapper.Map<Categories>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateCategories(objFromRepo);
            return NoContent();
        }

        //DELETE api/Categories/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCategorie(int id)
        {
            Categories obj = _service.GetCategoriesById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteCategories(obj);
            return NoContent();
        }


    }
}
