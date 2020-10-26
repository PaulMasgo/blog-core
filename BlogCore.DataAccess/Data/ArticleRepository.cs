using BlogCore.DataAccess.Data.Repository;
using BlogCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogCore.DataAccess.Data
{
    public class ArticleRepository : Repository<Article>, IArticleRepository
    {
        private readonly ApplicationDbContext _db;

        public ArticleRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void update(Article article)
        {
            Article art = _db.Article.FirstOrDefault(a => a.Id == article.Id);
            art.Name = article.Name;
            art.CreateDate = article.CreateDate;
            art.Description = article.Description;
            art.CategoryId = article.CategoryId;
            art.UrlImage = article.UrlImage;

        }
    }
}
