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
    public class CommandeController : ControllerBase
    {

        private readonly CommandeService _service;
        private readonly IMapper _mapper;

        public CommandeController(CommandeService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Commandes
        [HttpGet]
        public ActionResult<IEnumerable<CommandeAvecProduitDTO>> GetAllCommandes()
        {
            IEnumerable<Commande> listeCommandes = _service.GetAllCommandes();
            return Ok(_mapper.Map<IEnumerable<CommandeAvecProduitDTO>>(listeCommandes));
        }

        //GET api/Commandes/{i}
        [HttpGet("{id}", Name = "GetCommandeById")]
        public ActionResult<CommandeDTOOUT> GetCommandeById(int id)
        {
            Commande commandItem = _service.GetCommandeById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<CommandeDTOOUT>(commandItem));
            }
            return NotFound();
        }

        //POST api/Commandes
        [HttpPost]
        public ActionResult<CommandeDTOOUT> CreateCommande(Commande obj)
        {
            _service.AddCommande(obj);
            return CreatedAtRoute(nameof(GetCommandeById), new { Id = obj.IdCommande }, obj);
        }

        //POST api/Commandes/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateCommande(int id, CommandeDTOOUT obj)
        {
            Commande objFromRepo = _service.GetCommandeById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateCommande(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Commandes/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialCommandeUpdate(int id, JsonPatchDocument<Commande> patchDoc)
        {
            Commande objFromRepo = _service.GetCommandeById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Commande objToPatch = _mapper.Map<Commande>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateCommande(objFromRepo);
            return NoContent();
        }

        //DELETE api/Commandes/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCommande(int id)
        {
            Commande obj = _service.GetCommandeById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteCommande(obj);
            return NoContent();
        }


    }
}
