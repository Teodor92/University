namespace SimpleBookStore.Web.Mvc.ViewModels.Books
{
    using System.Collections.Generic;

    public class IndexViewModel
    {
        public IndexViewModel()
        {
            this.BookTypes = new List<BookTypeViewModel>();
            this.Books = new List<ShortBookViewModel>();
        }

        public IEnumerable<BookTypeViewModel> BookTypes { get; set; }

        public IEnumerable<ShortBookViewModel> Books { get; set; }
    }
}