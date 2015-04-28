namespace SimpleBookStore.Web.Mvc.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    using OJS.Web.Areas.Administration.Providers;

    using SimpleBookStore.Data;
    using SimpleBookStore.Data.Models;
    using SimpleBookStore.Web.Mvc.Providers;
    using SimpleBookStore.Web.Mvc.Providers.Contracts;
    using SimpleBookStore.Web.Mvc.Providers.Models;

    public class NewsController : BaseController
    {
        public NewsController(ISbsData data)
            : base(data)
        {
        }

        public NewsController(ISbsData data, User profile)
            : base(data, profile)
        {
        }

        public ActionResult Index()
        {
            var providers = new List<INewsProvider>
            {
                new BtvNewsProvider()
                ////new SoftUniNewsProvider(),
                ////new InfoManNewsProvider(),
                ////new InfosNewsProvider()
            };

            var news = new List<News>();

            foreach (var provider in providers)
            {
                news.AddRange(provider.FetchNews());
            }

            news = news.OrderByDescending(x => x.CreatedOn).ToList();

            return this.View(news);
        }
    }
}