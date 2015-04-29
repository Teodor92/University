namespace SimpleBookStore.Web.Mvc.ViewModels.Home
{
    using System.Collections.Generic;

    using SimpleBookStore.Web.Mvc.ViewModels.Books;

    public class SearchViewModel
    {
        public SearchViewModel()
        {
            this.Results = new List<ShortBookViewModel>();
        }

        public string QueryString { get; set; }

        public IEnumerable<ShortBookViewModel> Results { get; set; }
    }
}