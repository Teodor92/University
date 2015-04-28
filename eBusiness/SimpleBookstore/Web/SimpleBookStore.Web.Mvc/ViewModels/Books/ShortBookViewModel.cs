namespace SimpleBookStore.Web.Mvc.ViewModels.Books
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;

    using SimpleBookStore.Data.Models;

    public class ShortBookViewModel
    {
        public static Expression<Func<Book, ShortBookViewModel>> ViewModel
        {
            get
            {
                return book => new ShortBookViewModel
                {
                    Id = book.Id,
                    BookId = book.BookId,
                    Type = book.Type.Name,
                    Title = book.Title,
                    Author = book.Author,
                    Price = book.Price
                };
            }
        }

        public int Id { get; set; }

        [Display(Name = "Книга №")]
        public string BookId { get; set; }

        [Display(Name = "Тип")]
        public string Type { get; set; }

        [Display(Name = "Заглавие")]
        public string Title { get; set; }

        [Display(Name = "Автор")]
        public string Author { get; set; }

        [Display(Name = "Цена")]
        public decimal Price { get; set; }
    }
}