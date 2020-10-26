using BlogCore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogCore.DataAccess.Data.Repository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<SelectListItem> getListCategory();

        void update(Category category);

        
    }
}
