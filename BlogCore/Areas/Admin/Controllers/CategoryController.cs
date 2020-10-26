using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogCore.DataAccess.Data.Repository;
using BlogCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogCore.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IWorkContainer _workContainer;

        public CategoryController(IWorkContainer workContainer)
        {
            _workContainer = workContainer;
        }

        [HttpGet]
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
            Category category = new Category();
            category = _workContainer.category.Get(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _workContainer.category.add(category);
                _workContainer.save();
                return RedirectToAction(nameof(Index));
            }

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _workContainer.category.update(category);
                _workContainer.save();
                return RedirectToAction(nameof(Index));
            }

            return View(category);

        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Category category = _workContainer.category.Get(id);
            if (category == null)
            {
                return Json(new { success = false, message = "Error al eliminar categoria" });
            }

            _workContainer.category.Remove(category);
            _workContainer.save();

            return Json(new { success = true, message = "Categoria borrada correctamente" });

        }

        #region Llmadas a las apis

        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _workContainer.category.GetAll() });
        }



        #endregion

    }
}
