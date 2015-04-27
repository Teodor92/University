namespace SimpleBookStore.Web.Mvc.ViewModels.Books
{
    using System;
    using System.Linq.Expressions;

    using SimpleBookStore.Data.Models;

    public class BookViewModel
    {
        public static Expression<Func<Book, BookViewModel>> ViewModel
        {
            get
            {
                return book => new BookViewModel
                {
                    Id = book.Id,
                    BookId = book.BookId,
                    Type = book.Type.Name,
                    Title = book.Title,
                    Author = book.Author,
                    Description = book.Description,
                    Price = book.Price,
                    Quantity = book.Quantity,
                    IsOnSale = book.IsOnSale
                };
            }
        }

        public int Id { get; set; }

        public string BookId { get; set; }

        public string Type { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public bool IsOnSale { get; set; }
    }
}