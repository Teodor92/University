namespace Slms.Desktop.ViewModels.Display
{
    using System;
    using System.ComponentModel;
    using System.Linq.Expressions;

    using Slms.Data.Models;

    public class TagGridViewModel
    {
        public static Expression<Func<Tag, TagGridViewModel>> ViewModel
        {
            get
            {
                return x =>
                    new TagGridViewModel
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

        [Description("Брой тагнати книги")]
        public int NumberOfBooks { get; set; }
    }
}
