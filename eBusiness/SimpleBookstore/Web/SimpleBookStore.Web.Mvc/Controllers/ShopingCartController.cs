namespace SimpleBookStore.Web.Mvc.Controllers
{
    using System.Web.Mvc;

    using SimpleBookStore.Data;
    using SimpleBookStore.Data.Models;

    public class ShopingCartController : BaseController
    {
        public ShopingCartController(ISbsData data)
            : base(data)
        {
        }

        public ShopingCartController(ISbsData data, User profile)
            : base(data, profile)
        {
        }

        // GET: ShopingCart
        public ActionResult Index()
        {
            return this.View();
        }
    }
}