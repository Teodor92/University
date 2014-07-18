namespace Slms.Desktop.ViewModels.Display
{
    using System;
    using System.ComponentModel;
    using System.Linq;
    using System.Linq.Expressions;

    using Slms.Data.Models;

    public class BookGridViewModel
    {
        public static Expression<Func<Book, BookGridViewModel>> ViewModel
        {
            get
            {
                return x =>
                    new BookGridViewModel
                    {
                        Id = x.Id,
                        Title = x.Title,
                        Name = x.Author.Name,
                        Tags = string.Join(", ", x.Tags.Where(y => !y.IsDeleted).Select(y => y.Name)),
                        Category = x.Category.Name
                    };
            }
        }

        [Description("№")]
        public int Id { get; set; }

        [Description("Заглавие")]
        public string Title { get; set; }

        [Description("Автор")]
        public string Name { get; set; }

        [Description("Тагове")]
        public string Tags { get; set; }

        [Description("Категория")]
        public string Category { get; set; }
    }
}
