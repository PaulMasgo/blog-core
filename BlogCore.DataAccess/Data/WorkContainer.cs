using BlogCore.DataAccess.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogCore.DataAccess.Data
{
    public class WorkContainer : IWorkContainer
    {

        private readonly ApplicationDbContext _db;

        public ICategoryRepository category { get; private set; }
        public IArticleRepository article { get; private set; }
        public ISliderRepository slider { get; private set; }
        public IUserRepository applicationUser { get; private set; }

        public WorkContainer(ApplicationDbContext db)
        {
            _db = db;
            category = new CategoryRepository(_db);
            article = new ArticleRepository(_db);
            slider = new SliderRepository(_db);
            applicationUser = new UserRepository(_db);
        }

        public void Dispose()
        {
            _db.Dispose();

        }

        public void save()
        {
            _db.SaveChanges();
        }


    }
}
