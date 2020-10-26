using BlogCore.DataAccess.Data.Repository;
using BlogCore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogCore.DataAccess.Data
{
    public class SliderRepository : Repository<Slider>, ISliderRepository
    {

        private readonly ApplicationDbContext _db;

        public SliderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> getListSlider()
        {
            return _db.Slider.Select(s => new SelectListItem()
            {
                Text = s.Name,
                Value = s.Id.ToString()
            });
        }

        public void update(Slider slider)
        {
            Slider sld = _db.Slider.FirstOrDefault(s => s.Id == slider.Id);
            sld.Name = slider.Name;
            sld.State = slider.State;
            sld.UrlImage = slider.UrlImage;
            _db.SaveChanges();
        }
    }
}
