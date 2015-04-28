namespace SimpleBookStore.Web.Mvc.ViewModels.ShopingCart
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class IndexViewModel
    {
        public IndexViewModel()
        {
            this.ShopingCartItems = new List<ShopingCartItemViewModel>();
        }

        public IEnumerable<ShopingCartItemViewModel> ShopingCartItems { get; set; }

        [Display(Name = "Общо")]
        public decimal TotalSum
        {
            get { return this.ShopingCartItems.Sum(x => x.Book.Total); }
        }
    }
}