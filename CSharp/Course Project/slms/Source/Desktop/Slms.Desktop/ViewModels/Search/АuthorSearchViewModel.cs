namespace Slms.Desktop.ViewModels.Search
{
    using System;
    using System.ComponentModel;
    using System.Linq.Expressions;

    using Slms.Data.Models;

    public class АuthorSearchViewModel
    {
        public static Expression<Func<Author, АuthorSearchViewModel>> ViewModel
        {
            get
            {
                return x =>
                    new АuthorSearchViewModel
                    {
                        Name = x.Name,
                        BirthDay = x.BirthDay,
                        Country = x.Country.Name
                    };
            }
        }

        [Description("Име")]
        public string Name { get; set; }

        [Description("Рождена дата")]
        public DateTime BirthDay { get; set; }

        [Description("Страна")]
        public string Country { get; set; }
    }
}
