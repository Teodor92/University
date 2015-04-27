namespace SimpleBookStore.Web.Mvc.Controllers
{
    using System.Web.Mvc;

    using SimpleBookStore.Common;
    using SimpleBookStore.Data;
    using SimpleBookStore.Data.Models;
    using SimpleBookStore.Web.Mvc.ViewModels.Home;

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

        [HttpGet]
        public ActionResult Index()
        {
            ////MailSender.Instance.SendMail("teodor.ivanov92@gmail.com", "test", "test");

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            var viewModel = new ContactUsViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Contact(ContactUsViewModel viewModel)
        {
            if (this.ModelState.IsValid)
            {
                // TODO: Send mail
            }

            return View(viewModel);
        }
    }
}