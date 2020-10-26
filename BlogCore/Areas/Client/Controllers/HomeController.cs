using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlogCore.Models;
using BlogCore.DataAccess.Data.Repository;
using BlogCore.Models.ViewModel;

namespace BlogCore.Controllers
{   [Area("Client")]
    public class HomeController : Controller
    {
        private readonly IWorkContainer _workContainer;

        public HomeController(IWorkContainer workContainer)
        {
            _workContainer = workContainer;
        }

        public IActionResult Index()
        {
            HomeVM home = new HomeVM
            {
                Articles = _workContainer.article.GetAll(),
                Sliders = _workContainer.slider.GetAll()
            };

            return View(home);
        }

        public IActionResult Details(int id)
        {
            Article article = _workContainer.article.Get(id);
            
            if (article == null)
            {
                return NotFound();
            }

            return View(article);

        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
