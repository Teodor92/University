namespace SimpleBookStore.Web.Mvc.ViewModels.Books
{
    using System.Collections.Generic;

    public class IndexViewModel
    {
        public IndexViewModel()
        {
            this.BookTypes = new List<BookTypeViewModel>();
            this.Books = new List<BookViewModel>();
        }

        public IEnumerable<BookTypeViewModel> BookTypes { get; set; }

        public IEnumerable<BookViewModel> Books { get; set; }
    }
}