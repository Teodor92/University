namespace Slms.Desktop.ViewModels.Display
{
    using System;
    using System.ComponentModel;
    using System.Linq.Expressions;

    using Slms.Data.Models;

    public class CountryGridViewModel
    {
        public static Expression<Func<Country, CountryGridViewModel>> ViewModel
        {
            get
            {
                return x =>
                    new CountryGridViewModel
                    {
                        Id = x.Id,
                        Name = x.Name,
                        NumberOfAuthors = x.Authors.Count
                    };
            }
        }

        [Description("№")]
        public int Id { get; set; }

        [Description("Име")]
        public string Name { get; set; }

        [Description("Брой автори")]
        public int NumberOfAuthors { get; set; }
    }
}
