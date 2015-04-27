namespace SimpleBookStore.Web.Mvc.ViewModels.Books
{
    using System;
    using System.ComponentModel.DataAnnotations;
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
                    IsOnSale = book.IsOnSale,
                    ImagePath = "/Content/Images/BookPictures/" + book.BookId + ".jpg"
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

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        [Display(Name = "Количество")]
        public int Quantity { get; set; }

        [Display(Name = "В разпродажба")]
        public bool IsOnSale { get; set; }

        public string ImagePath { get; set; }
    }
}