using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Dtos;
using WebApplication1.Data.Models;
using WebApplication1.Data.Services;
using WebApplication1.Helpers;

namespace WebApplication1.Controllers
{
    [Route("api/Personnes")]
    [ApiController]

    public class PersonnesController : ControllerBase
    {
        private readonly PersonnesServices _service;
        private readonly IMapper _mapper;

        public PersonnesController(PersonnesServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }


        //GET api/Personnes
        [HttpGet]
        public ActionResult<IEnumerable<Personne>> GetAllPersonnes()
        {
            IEnumerable<Personne> listePersonnes = _service.GetAllPersonnes();
            return Ok(_mapper.Map<IEnumerable<PersonneDTO>>(listePersonnes));
        }

        
        [HttpGet("{id}", Name = "GetPersonneById")]
        public ActionResult<PersonneDTO> GetPersonneById(int id)
        {
            var commandItem = _service.GetPersonneById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<PersonneDTO>(commandItem));
            }
            return NotFound();
        }



        [HttpPost]
        public ActionResult<IEnumerable<Personne>> CreatePersonne(Personne personne)
        {
            //on ajoute l’objet à la base de données
            _service.AddPersonnes(personne);
            //on retourne le chemin de findById avec l'objet créé
            return CreatedAtRoute(nameof(GetPersonneById), new
            {
                Id =
                    personne.IdPersonne
                    }, personne);
        }

        
        [HttpPut("{id}")]

                public ActionResult UpdatePersonne(int id, PersonneDTO personne)
        {
            var personneFromRepo = _service.GetPersonneById(id);
            if (personneFromRepo == null)
            {
                return NotFound();
            }
            personneFromRepo.Dump();
            _mapper.Map(personne, personneFromRepo);
            personneFromRepo.Dump();
            personne.Dump();
            // inutile puisque la fonction ne fait rien, mais garde la cohérence
            _service.UpdatePersonne(personneFromRepo);
            return NoContent();
        }
        
    }
}
