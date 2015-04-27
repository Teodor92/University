namespace SimpleBookStore.Web.Mvc.Controllers
{
    using System.Web.Mvc;

    using SimpleBookStore.Data;
    using SimpleBookStore.Data.Models;

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
            return this.View();
        }
    }
}