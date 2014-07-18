namespace Slms.Desktop.ViewModels.Search
{
    using System;
    using System.ComponentModel;
    using System.Linq;
    using System.Linq.Expressions;

    using Slms.Data.Models;

    public class BookComplexSearchViewModel
    {
        public static Expression<Func<Book, BookComplexSearchViewModel>> ViewModel
        {
            get
            {
                return x =>
                    new BookComplexSearchViewModel
                    {
                        Title = x.Title,
                        Name = x.Author.Name,
                        Tags = string.Join(", ", x.Tags.Select(y => y.Name)),
                        Category = x.Category.Name
                    };
            }
        }

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
