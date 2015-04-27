namespace SimpleBookStore.Web.Mvc.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using SimpleBookStore.Data;
    using SimpleBookStore.Data.Models;
    using SimpleBookStore.Web.Mvc.ViewModels.Books;

    public class BooksController : BaseController
    {
        public BooksController(ISbsData data)
            : base(data)
        {
        }

        public BooksController(ISbsData data, User profile)
            : base(data, profile)
        {
        }

        public ActionResult Index()
        {
            var bookViewModels = this.Data.Books
                .All()
                .Select(BookViewModel.ViewModel)
                .ToList();

            var bookTypesViewModels = this.Data.BookTypes
                .All()
                .Select(BookTypeViewModel.ViewModel)
                .ToList();

            var viewModel = new IndexViewModel()
            {
                BookTypes = bookTypesViewModels,
                Books = bookViewModels
            };

            return this.View(viewModel);
        }

        public ActionResult Details()
        {
            return this.View();
        }
    }
}