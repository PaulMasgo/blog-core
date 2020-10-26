using BlogCore.DataAccess.Data.Repository;
using BlogCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogCore.DataAccess.Data
{
    public class UserRepository : Repository<ApplicationUser>, IUserRepository
    {
        private readonly ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void BlockUser(string IdUser)
        {
            ApplicationUser user = _db.ApplicationUsers.FirstOrDefault(u => u.Id == IdUser);
            user.LockoutEnd = DateTime.Now.AddYears(100);
            _db.SaveChanges();
        }

        public void UnlockUser(string IdUser)
        {
            ApplicationUser user = _db.ApplicationUsers.FirstOrDefault(u => u.Id == IdUser);
            user.LockoutEnd = DateTime.Now;
            _db.SaveChanges();
        }

    }
}
