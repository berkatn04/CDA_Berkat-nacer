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
    class ArticlesController : ControllerBase
    {

        private readonly ArticlesService _service;
        private readonly IMapper _mapper;

        public ArticlesController(ArticlesService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public ArticlesController(MyDbContext _context)
        {
            _service = new ArticlesService(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ArticlesProfile>();
            });
            _mapper = config.CreateMapper();
        }

        //GET api/Articles
        [HttpGet]
        public IEnumerable<ArticlesDTOOUT> GetAllArticles()
        {
            IEnumerable<Articles> listeArticles = _service.GetAllArticles();
            return _mapper.Map<IEnumerable<ArticlesDTOOUT>>(listeArticles);
        }

        //GET api/Articles/{i}
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

        //POST api/Articles
        [HttpPost]
        public ActionResult<ArticlesDTOOUT> CreateArticles(Articles obj)
        {
            _service.AddArticle(obj);
            return CreatedAtRoute(nameof(GetArticlesById), new { Id = obj.IdArticle }, obj);
        }

        //POST api/Articles/{id}
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
        //PATCH api/Articles/{id}
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

        //DELETE api/Articles/{id}
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
