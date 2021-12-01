﻿using AutoMapper;
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
    public class ProduitController : ControllerBase
    {

        private readonly ProduitService _service;
        private readonly IMapper _mapper;

        public ProduitController(ProduitService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Produits
        [HttpGet]
        public ActionResult<IEnumerable<ProduitDTOOUT>> GetAllProduits()
        {
            IEnumerable<Produit> listeProduits = _service.GetAllProduits();
            return Ok(_mapper.Map<IEnumerable<ProduitDTOOUT>>(listeProduits));
        }

        //GET api/Produits/{i}
        [HttpGet("{id}", Name = "GetProduitById")]
        public ActionResult<ProduitDTOOUT> GetProduitById(int id)
        {
            Produit commandItem = _service.GetProduitById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<ProduitDTOOUT>(commandItem));
            }
            return NotFound();
        }

        //POST api/Produits
        [HttpPost]
        public ActionResult<ProduitDTOOUT> CreateProduit(Produit obj)
        {
            _service.AddProduit(obj);
            return CreatedAtRoute(nameof(GetProduitById), new { Id = obj.IdProduit }, obj);
        }

        //POST api/Produits/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateProduit(int id, ProduitDTOOUT obj)
        {
            Produit objFromRepo = _service.GetProduitById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateProduit(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Produits/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialProduitUpdate(int id, JsonPatchDocument<Produit> patchDoc)
        {
            Produit objFromRepo = _service.GetProduitById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Produit objToPatch = _mapper.Map<Produit>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateProduit(objFromRepo);
            return NoContent();
        }

        //DELETE api/Produits/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteProduit(int id)
        {
            Produit obj = _service.GetProduitById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteProduit(obj);
            return NoContent();
        }


    }
}
