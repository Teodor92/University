namespace SimpleBookStore.Web.Mvc.Controllers
{
    using System.Web.Mvc;

    using SimpleBookStore.Data;
    using SimpleBookStore.Data.Models;

    public class BooksController : BaseController
    {
        public BooksController(ISbsData data)
            : base(data)
        {
        }

        public BooksController(ISbsData data, User profile)
            : base(data, profile)
        {
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}