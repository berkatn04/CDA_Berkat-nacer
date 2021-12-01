using AutoMapper;
using GestionStock.Data.DTOS;
using GestionStock.Data.Models;
using GestionStock.Data.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Data.Controllers
{
    class TypeProduitsController : ControllerBase
    {

        private readonly TypeProduitsService _service;
        private readonly IMapper _mapper;

        public TypeProduitsController(TypeProduitsService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/TypeProduits
        [HttpGet]
        public ActionResult<IEnumerable<TypeProduitsDTOOUT>> GetAllTypeProduits()
        {
            IEnumerable<TypeProduits> listeTypeProduits = _service.GetAllTypeProduits();
            return Ok(_mapper.Map<IEnumerable<TypeProduitsDTOOUT>>(listeTypeProduits));
        }

        //GET api/TypeProduits/{i}
        [HttpGet("{id}", Name = "GetTypeProduitById")]
        public ActionResult<TypeProduitsDTOOUT> GetTypeProduitById(int id)
        {
            TypeProduits commandItem = _service.GetTypeProduitsById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<TypeProduitsDTOOUT>(commandItem));
            }
            return NotFound();
        }

        //POST api/TypeProduits
        [HttpPost]
        public ActionResult<TypeProduitsDTOOUT> CreateTypeProduit(TypeProduits obj)
        {
            _service.AddTypeProduits(obj);
            return CreatedAtRoute(nameof(GetTypeProduitById), new { Id = obj.IdTypeProduits }, obj);
        }

        //POST api/TypeProduits/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateTypeProduit(int id, TypeProduitsDTOOUT obj)
        {
            TypeProduits objFromRepo = _service.GetTypeProduitsById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateTypeProduits(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/TypeProduits/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialTypeProduitUpdate(int id, JsonPatchDocument<TypeProduits> patchDoc)
        {
            TypeProduits objFromRepo = _service.GetTypeProduitsById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            TypeProduits objToPatch = _mapper.Map<TypeProduits>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateTypeProduits(objFromRepo);
            return NoContent();
        }

        //DELETE api/TypeProduits/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteTypeProduit(int id)
        {
            TypeProduits obj = _service.GetTypeProduitsById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteTypeProduits(obj);
            return NoContent();
        }


    }
}
