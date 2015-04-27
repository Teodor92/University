namespace SimpleBookStore.Web.Mvc.Controllers
{
    using System.Web.Mvc;

    using SimpleBookStore.Common;
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
            ////MailSender.Instance.SendMail("teodor.ivanov92@gmail.com", "test", "test");

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}