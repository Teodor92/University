namespace Slms.Desktop.ViewModels.Display
{
    using System;
    using System.ComponentModel;
    using System.Linq.Expressions;

    using Slms.Data.Models;

    public class CategoryGridViewModel
    {
        public static Expression<Func<Category, CategoryGridViewModel>> ViewModel
        {
            get
            {
                return x =>
                    new CategoryGridViewModel
                    {
                        Id = x.Id,
                        Name = x.Name,
                        NumberOfBooks = x.Books.Count,
                    };
            }
        }

        [Description("№")]
        public int Id { get; set; }

        [Description("Име")]
        public string Name { get; set; }

        [Description("Брой книги")]
        public int NumberOfBooks { get; set; }
    }
}
