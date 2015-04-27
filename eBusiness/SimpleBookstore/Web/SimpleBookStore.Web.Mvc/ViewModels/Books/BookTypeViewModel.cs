namespace SimpleBookStore.Web.Mvc.ViewModels.Books
{
    using System.Linq.Expressions;

    using SimpleBookStore.Data.Models;
    using System;

    public class BookTypeViewModel
    {
        public static Expression<Func<BookType, BookTypeViewModel>> ViewModel
        {
            get
            {
                return bookType => new BookTypeViewModel
                {
                    Id = bookType.Id,
                    Name = bookType.Name,
                };
            }
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsSelected { get; set; }
    }
}