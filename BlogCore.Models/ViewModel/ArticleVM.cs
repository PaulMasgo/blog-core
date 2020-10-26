using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogCore.Models.ViewModel
{
    public class ArticleVM
    {
        public Article Article { get; set; }
        public  IEnumerable<SelectListItem> ListCategory { get; set; }
    }
}
