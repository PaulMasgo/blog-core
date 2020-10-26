using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlogCore.DataAccess.Data;
using BlogCore.DataAccess.Data.Repository;
using BlogCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BlogCore.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class SliderController : Controller
    {

        private readonly IWorkContainer _workContainer;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public SliderController(IWorkContainer workContainer,IWebHostEnvironment webHostEnvironment)
        {
            _workContainer = workContainer;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Slider slider =  _workContainer.slider.Get(id);
            if (slider == null)
            {
                return NotFound();
            }

            return View(slider);
        }


        // Lamada a las apis 
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json( new { data = _workContainer.slider.GetAll() });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Slider slider)
        {
            var files = HttpContext.Request.Form.Files;

            if (files.Count() > 0)
            {
                string mainRoute = _webHostEnvironment.WebRootPath;
                string fileName = Guid.NewGuid().ToString();
                string Uploads = Path.Combine(mainRoute, @"images\sliders");
                string extension = Path.GetExtension(files[0].FileName);

                using (FileStream fs = new FileStream(Path.Combine(Uploads, $"{fileName}{extension}"), FileMode.Create))
                {
                    files[0].CopyTo(fs);
                };

                slider.UrlImage = @$"\images\sliders\{fileName}{extension}";
                ModelState["UrlImage"].ValidationState = ModelValidationState.Valid;
            }
            else
            {
                slider.UrlImage = null;
            }

            if (ModelState.IsValid)
            {
                _workContainer.slider.add(slider);
                _workContainer.save();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Slider slider)
        {
            var files = HttpContext.Request.Form.Files;

            if (files.Count() > 0)
            {
                string mainRoute = _webHostEnvironment.WebRootPath;
                string fileName = Guid.NewGuid().ToString();
                string Uploads = Path.Combine(mainRoute, @"images\sliders");
                string extension = Path.GetExtension(files[0].FileName);

                using (FileStream fs = new FileStream(Path.Combine(Uploads, $"{fileName}{extension}"), FileMode.Create))
                {
                    files[0].CopyTo(fs);
                };

                //Eliminar imagen 
                string imageOld = Path.Combine(mainRoute, slider.UrlImage.TrimStart('\\'));
                if (System.IO.File.Exists(imageOld))
                {
                    System.IO.File.Delete(imageOld);
                }

                slider.UrlImage = @$"\images\sliders\{fileName}{extension}";
            }

            if (ModelState.IsValid)
            {
                _workContainer.slider.update(slider);
                _workContainer.save();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Slider slider = _workContainer.slider.Get(id);

            if (slider == null)
            {
                return Json(new { success = false, message = "Error al eliminar registro" });
            }

            _workContainer.slider.Remove(id);
            _workContainer.save();

            return Json(new { success = true, message = "registro borrado" });

        }

    }
}
