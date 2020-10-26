using BlogCore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace BlogCore.DataAccess.Data.Repository
{
    public interface ISliderRepository : IRepository<Slider>
    {
        IEnumerable<SelectListItem> getListSlider();
        void update(Slider slider);
    }
}
