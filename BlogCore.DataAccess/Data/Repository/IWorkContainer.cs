using System;
using System.Collections.Generic;
using System.Text;

namespace BlogCore.DataAccess.Data.Repository
{
    public interface IWorkContainer : IDisposable
    {
        ICategoryRepository category { get; }
        IArticleRepository article { get; }
        ISliderRepository slider { get; }

        IUserRepository applicationUser { get; }

        void save();
    }
}
