using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using voiture.Data.Dto;
using voiture.Data.Models;
using voiture.Data.Services;
//using voiture.Helpers;

namespace voiture.Controllers
{
    [Route("api/Voitures")]
    [ApiController]


    public class VoitureController : ControllerBase
    {
        private readonly VoitureService _service;
        private readonly IMapper _mapper;

        public VoitureController(VoitureService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Voiture>> GetAllVoiture()
        {

            IEnumerable<Voiture> listeVoitures = _service.GetAllVoiture();
            return Ok(_mapper.Map<IEnumerable<VoitureDTO>>(listeVoitures));
        }

        [HttpGet("{id}", Name = "GetPersonneById")]
        public ActionResult<VoitureDTO> GetPersonneById(int id)
        {
            var commandItem = _service.GetPersonneById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<VoitureDTO>(commandItem));
            }
            return NotFound();
        }


        [HttpPost]
        public ActionResult<VoitureDTO> CreatePersonne(Voiture personne)
        {
            //on ajoute l’objet à la base de données
            _service.AddPersonnes(personne);
            //on retourne le chemin de findById avec l'objet créé
            return CreatedAtRoute(nameof(GetPersonneById), new
            {
                Id =
           personne.IdVoiture
            }, personne);
        }

        [HttpDelete("{id}")]
        public ActionResult DeletePersonne(int id)
        {
            var voitureModelFromRepo = _service.GetPersonneById(id);
            if (voitureModelFromRepo == null)
            {
                return NotFound();
            }
            _service.DeletePersonne(voitureModelFromRepo);
            return NoContent();
        }



    }
}
