using BlogCore.DataAccess.Data.Repository;
using BlogCore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogCore.DataAccess.Data
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext Db) : base (Db)
        {
            _db = Db;
        }

        public IEnumerable<SelectListItem> getListCategory()
        {
            return _db.Category.Select(c => new SelectListItem()
            {
                Text = c.Name,
                Value = c.Id.ToString()
            });
        }

        public void update(Category category)
        {
            var Object = _db.Category.FirstOrDefault(c => c.Id == category.Id);
            Object.Name = category.Name;
            Object.Order = category.Order;

            _db.SaveChanges();

        }
    }
}
