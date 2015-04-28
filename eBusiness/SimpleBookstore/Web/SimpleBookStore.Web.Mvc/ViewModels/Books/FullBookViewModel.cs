using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBookStore.Web.Mvc.ViewModels.Books
{
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;

    using SimpleBookStore.Data.Models;

    public class FullBookViewModel : ShortBookViewModel
    {
        public new static Expression<Func<Book, FullBookViewModel>> ViewModel
        {
            get
            {
                return book => new FullBookViewModel
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

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Количество")]
        public int Quantity { get; set; }

        [Display(Name = "В разпродажба")]
        public bool IsOnSale { get; set; }

        public string ImagePath { get; set; }

        public decimal Total
        {
            get { return this.Price * this.Quantity; }
        }
    }
}