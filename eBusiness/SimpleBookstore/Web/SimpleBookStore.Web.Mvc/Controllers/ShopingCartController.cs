namespace SimpleBookStore.Web.Mvc.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using SimpleBookStore.Data;
    using SimpleBookStore.Data.Models;
    using SimpleBookStore.Web.Mvc.ViewModels.ShopingCart;

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

        [Authorize]
        public ActionResult Index()
        {
            var shopingCartItems = this.Data.ShopingCart
                .All()
                .Where(x => x.UserId == this.UserProfile.Id)
                .Select(ShopingCartItemViewModel.ViewModel)
                .ToList();

            var viewModel = new IndexViewModel()
            {
                ShopingCartItems = shopingCartItems
            };

            return this.View(viewModel);
        }
    }
}