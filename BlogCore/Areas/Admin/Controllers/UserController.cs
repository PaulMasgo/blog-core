using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BlogCore.DataAccess.Data.Repository;
using BlogCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogCore.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IWorkContainer _workContainer;

        public UserController(IWorkContainer workContainer)
        {
            _workContainer = workContainer;
        }

        public IActionResult Index()
        {
            var claimsUser = (ClaimsIdentity)this.User.Identity;
            var currentUser = claimsUser.FindFirst(ClaimTypes.NameIdentifier);
            return View(_workContainer.applicationUser.GetAll(u => u.Id != currentUser.Value));
        }

        public IActionResult Block(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            _workContainer.applicationUser.BlockUser(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Unlock(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            _workContainer.applicationUser.UnlockUser(id);
            return RedirectToAction(nameof(Index));
        }



    }
}
