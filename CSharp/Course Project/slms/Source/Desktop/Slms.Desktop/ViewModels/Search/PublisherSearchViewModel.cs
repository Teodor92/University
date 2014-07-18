namespace Slms.Desktop.ViewModels.Search
{
    using System;
    using System.ComponentModel;
    using System.Linq.Expressions;

    using Slms.Data.Models;

    public class PublisherSearchViewModel
    {
        public static Expression<Func<Publisher, PublisherSearchViewModel>> ViewModel
        {
            get
            {
                return x =>
                    new PublisherSearchViewModel
                    {
                        Name = x.Name,
                        Adress = x.Adress
                    };
            }
        }

        [Description("Име")]
        public string Name { get; set; }

        [Description("Адрес")]
        public string Adress { get; set; }
    }
}
