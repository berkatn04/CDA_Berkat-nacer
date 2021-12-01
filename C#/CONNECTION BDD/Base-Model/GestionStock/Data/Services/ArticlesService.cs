using GestionStock.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Data.Services
{
    class ArticlesService
    {

        private readonly MyDbContext _context;

        public ArticlesService(MyDbContext context)
        {
            _context = context;
        }

        public void AddArticle(Articles obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Article.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteArticle(Articles obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Article.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Articles> GetAllArticles()
        {
            return _context.Article.ToList();
        }

        public Articles GetArticleById(int id)
        {
            return _context.Article.FirstOrDefault(obj => obj.IdArticle == id);
        }

        public void UpdateArticle(Articles obj)
        {
            _context.SaveChanges();
        }


    }
}
