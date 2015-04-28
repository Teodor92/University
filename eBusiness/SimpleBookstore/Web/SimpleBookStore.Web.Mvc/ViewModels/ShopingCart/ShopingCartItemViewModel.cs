namespace SimpleBookStore.Web.Mvc.ViewModels.ShopingCart
{
    using System;
    using System.Linq.Expressions;

    using SimpleBookStore.Data.Models;
    using SimpleBookStore.Web.Mvc.ViewModels.Books;

    public class ShopingCartItemViewModel
    {
        public static Expression<Func<ShopingCartItem, ShopingCartItemViewModel>> ViewModel
        {
            get
            {
                return item => new ShopingCartItemViewModel
                {
                    Id = item.Id,
                    Book = new FullBookViewModel
                    {
                        Id = item.BookId,
                        BookId = item.Book.BookId,
                        Type = item.Book.Type.Name,
                        Title = item.Book.Title,
                        Author = item.Book.Author,
                        Description = item.Book.Description,
                        Price = item.Book.Price,
                        Quantity = item.Book.Quantity,
                        IsOnSale = item.Book.IsOnSale,
                        ImagePath = "/Content/Images/BookPictures/" + item.Book.BookId + ".jpg"
                    }
                };
            }
        }

        public int Id { get; set; }

        public string OrderId { get; set; }

        public FullBookViewModel Book { get; set; }
    }
}