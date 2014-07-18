namespace Slms.Desktop.ViewModels.Display
{
    using System;
    using System.ComponentModel;
    using System.Linq.Expressions;

    using Slms.Data.Models;

    public class AuthorGridViewModel
    {
        public static Expression<Func<Author, AuthorGridViewModel>> ViewModel
        {
            get
            {
                return x =>
                    new AuthorGridViewModel
                    {
                        Id = x.Id,
                        Name = x.Name,
                        BirthDay = x.BirthDay,
                        Country = x.Country.Name
                    };
            }
        }

        [Description("№")]
        public int Id { get; set; }

        [Description("Име")]
        public string Name { get; set; }

        [Description("Рождена дата")]
        public DateTime BirthDay { get; set; }

        [Description("Страна")]
        public string Country { get; set; }
    }
}
