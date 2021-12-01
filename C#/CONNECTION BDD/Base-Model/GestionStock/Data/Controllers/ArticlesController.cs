using AutoMapper;
using GestionStock.Data.DTOS;
using GestionStock.Data.Models;
using GestionStock.Data.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GestionStock.Data.Controllers
{
    class ArticlesController : ControllerBase
    {

        private readonly ArticlesService _service;
        private readonly IMapper _mapper;

        public ArticlesController(ArticlesService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public ArticlesController(MyDbContext ctx, IMapper mapper)
        {
            _service = new ArticlesService(ctx);
            _mapper = mapper;
        }

        //GET api/Articless
        [HttpGet]
        public ActionResult<IEnumerable<ArticlesDTOOUT>> GetAllArticless()
        {
            IEnumerable<Articles> listeArticless = _service.GetAllArticles();
            return Ok(_mapper.Map<IEnumerable<ArticlesDTOOUT>>(listeArticless));
        }

        //GET api/Articless/{i}
        [HttpGet("{id}", Name = "GetArticlesById")]
        public ActionResult<ArticlesDTOOUT> GetArticlesById(int id)
        {
            Articles commandItem = _service.GetArticleById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<ArticlesDTOOUT>(commandItem));
            }
            return NotFound();
        }

        //POST api/Articless
        [HttpPost]
        public ActionResult<ArticlesDTOOUT> CreateArticles(Articles obj)
        {
            _service.AddArticle(obj);
            return CreatedAtRoute(nameof(GetArticlesById), new { Id = obj.IdArticle }, obj);
        }

        //POST api/Articless/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateArticles(int id, ArticlesDTOOUT obj)
        {
            Articles objFromRepo = _service.GetArticleById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateArticle(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Articless/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialArticlesUpdate(int id, JsonPatchDocument<Articles> patchDoc)
        {
            Articles objFromRepo = _service.GetArticleById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Articles objToPatch = _mapper.Map<Articles>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateArticle(objFromRepo);
            return NoContent();
        }

        //DELETE api/Articless/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteArticles(int id)
        {
            Articles obj = _service.GetArticleById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteArticle(obj);
            return NoContent();
        }


    }
}
