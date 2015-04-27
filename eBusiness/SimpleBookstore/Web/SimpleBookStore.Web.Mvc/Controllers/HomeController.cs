namespace SimpleBookStore.Web.Mvc.Controllers
{
    using System.Web.Mvc;

    using SimpleBookStore.Data;
    using SimpleBookStore.Data.Models;

    public class HomeController : BaseController
    {
        public HomeController(ISbsData data)
            : base(data)
        {
        }

        public HomeController(ISbsData data, User profile)
            : base(data, profile)
        {
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}