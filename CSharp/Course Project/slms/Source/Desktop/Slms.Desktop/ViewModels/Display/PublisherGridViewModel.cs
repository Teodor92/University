namespace Slms.Desktop.ViewModels.Display
{
    using System;
    using System.ComponentModel;
    using System.Linq.Expressions;

    using Slms.Data.Models;

    public class PublisherGridViewModel
    {
        public static Expression<Func<Publisher, PublisherGridViewModel>> ViewModel
        {
            get
            {
                return x =>
                    new PublisherGridViewModel
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Adress = x.Adress
                    };
            }
        }

        [Description("№")]
        public int Id { get; set; }

        [Description("Име")]
        public string Name { get; set; }

        [Description("Адрес")]
        public string Adress { get; set; }
    }
}
