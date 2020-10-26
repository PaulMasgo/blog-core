using BlogCore.Models;
using BlogCore.Utilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace BlogCore.DataAccess.Data.Initializer
{
    public class InitializerDB : IInitilazerDB
    {

        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public InitializerDB(ApplicationDbContext db,UserManager<IdentityUser> userManager,RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void Initializer()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception)
            {

                throw;
            }

            if (_db.Roles.Any(roles => roles.Name == Cnt.Admin)) return;

            _roleManager.CreateAsync(new IdentityRole(Cnt.Admin)).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole(Cnt.User)).GetAwaiter().GetResult();

            _userManager.CreateAsync(new ApplicationUser
            {
                Name = "Jean Ramos Masgo",
                Email = "ramos@gmail.com",
                EmailConfirmed = true,
                UserName = "ramos@gmail.com"
            }, "123456789").GetAwaiter().GetResult();

            ApplicationUser usuario = _db.ApplicationUsers.Where(user => user.Email == "ramos@gmail.com").FirstOrDefault();

            _userManager.AddToRoleAsync(usuario, Cnt.Admin).GetAwaiter().GetResult();
            

        }
    }
}
