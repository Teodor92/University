namespace SimpleBookStore.Web.Mvc.Controllers
{
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using System.Web.Routing;

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
        public async Task<ActionResult> Contact(ContactUsViewModel viewModel)
        {
            if (this.ModelState.IsValid)
            {
                await MailSender.Instance.SendMailAsync(viewModel.To, viewModel.Title, viewModel.Content);

                this.TempData[GlobalConstants.SuccessMessage] = "Успешно изпратихте имейл!";
                return this.RedirectToAction("Contact", "Home", new { area = string.Empty });
            }

            return View(viewModel);
        }
    }
}