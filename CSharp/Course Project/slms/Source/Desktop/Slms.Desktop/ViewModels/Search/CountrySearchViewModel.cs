namespace Slms.Desktop.ViewModels.Search
{
    using System;
    using System.ComponentModel;
    using System.Linq.Expressions;

    using Slms.Data.Models;

    public class CountrySearchViewModel
    {
        public static Expression<Func<Country, CountrySearchViewModel>> ViewModel
        {
            get
            {
                return x =>
                    new CountrySearchViewModel
                    {
                        Name = x.Name,
                        NumberOfAuthors = x.Authors.Count
                    };
            }
        }

        [Description("Име")]
        public string Name { get; set; }

        [Description("Брой автори")]
        public int NumberOfAuthors { get; set; }
    }
}
