using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlogCore.DataAccess.Data.Repository;
using BlogCore.Models;
using BlogCore.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace BlogCore.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly IWorkContainer _workContainer;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ArticleController(IWorkContainer workContainer,IWebHostEnvironment webHostEnvironment)
        {
            _workContainer = workContainer;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            ArticleVM articleVM = new ArticleVM
            {
                Article = new Article(),
                ListCategory = _workContainer.category.getListCategory()

            };
            return View(articleVM);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ArticleVM articleVM = new ArticleVM
            {
                Article = new Article(),
                ListCategory = _workContainer.category.getListCategory()
            };

            if (id != null)
            {
                articleVM.Article = _workContainer.article.Get(id);
            }

            return View(articleVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ArticleVM articleVM)
        {
            if (ModelState.IsValid)
            {

                Article art = _workContainer.article.Get(articleVM.Article.Id);

                string mainRoute = _webHostEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;

                if (files.Count() > 0)
                {
                    // Editar imagen
                    string fileName = Guid.NewGuid().ToString();
                    string Uploads = Path.Combine(mainRoute, @"images\articles");
                    string extension = Path.GetExtension(files[0].FileName);

                    //Eliminar imagen 
                    string imageOld = Path.Combine(mainRoute, art.UrlImage.TrimStart('\\'));
                    if (System.IO.File.Exists(imageOld))
                    {
                        System.IO.File.Delete(imageOld);
                    }

                    // Subir nuevament la imagen
                    using (FileStream fs = new FileStream(Path.Combine(Uploads, $"{fileName}{extension}"), FileMode.Create))
                    {
                        files[0].CopyTo(fs);
                    };

                    articleVM.Article.UrlImage = @$"\images\articles\{fileName}{extension}";  
                }
                _workContainer.article.update(articleVM.Article);
                _workContainer.save();

                return RedirectToAction(nameof(Index));       
            }

            return View();

        }

        public IActionResult Create()
        {       
            ArticleVM articleVM = new ArticleVM
            {
                Article = new Article(),
                ListCategory = _workContainer.category.getListCategory()

            };
            return View(articleVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ArticleVM articleVM)
        {
            if (ModelState.IsValid)
            {
                string mainRoute = _webHostEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;

                if (articleVM.Article.Id == 0) 
                {
                    // Creación de Nuevo Articulo
                    string fileName = Guid.NewGuid().ToString();
                    string Uploads = Path.Combine(mainRoute, @"images\articles");
                    string extension = Path.GetExtension(files[0].FileName);

                    using (FileStream fs = new FileStream(Path.Combine(Uploads, $"{fileName}{extension}"),FileMode.Create))
                    {
                        files[0].CopyTo(fs);
                    };

                    articleVM.Article.UrlImage = @$"\images\articles\{fileName}{extension}";
                    _workContainer.article.add(articleVM.Article);
                    _workContainer.save();

                    return RedirectToAction(nameof(Index));
                }
            }

            return View();

        }

        //Seccion de apis

        public IActionResult GetAll()
        {
            return Json(new { data = _workContainer.article.GetAll(includeProperties:"category") });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Article article = _workContainer.article.Get(id);

            string mainRoute = _webHostEnvironment.WebRootPath;

            if (article.UrlImage != null)
            {
                string imageOld = Path.Combine(mainRoute, article.UrlImage.TrimStart('\\'));
                if (System.IO.File.Exists(imageOld))
                {
                    System.IO.File.Delete(imageOld);
                };
            };

            _workContainer.article.Remove(article);
            _workContainer.save();

            return Json(new { success = true, message = "El articulo fue borrado" });

        }



    }
}
