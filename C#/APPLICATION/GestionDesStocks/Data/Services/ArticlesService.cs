using GestionDesStocks.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesStocks.Data.Services
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
            _context.Articles.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteArticle(Articles obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Articles.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Articles> GetAllArticles()
        {
            return _context.Articles.Include("Categorie").ToList();
        }

        public Articles GetArticleById(int id)
        {
            return _context.Articles.FirstOrDefault(obj => obj.IdArticle == id);
        }

        public void UpdateArticle(Articles obj)
        {
            _context.SaveChanges();
        }


    }
}
