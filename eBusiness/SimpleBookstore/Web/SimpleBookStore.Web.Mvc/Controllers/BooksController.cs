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

        public ActionResult Index(int? id)
        {
            var bookTypesViewModels = this.Data.BookTypes
                .All()
                .Select(BookTypeViewModel.ViewModel)
                .ToList();

            var booksRaw = this.Data.Books
                .All();

            if (id.HasValue)
            {
                booksRaw = booksRaw.Where(x => x.TypeId == id);

                var bookTypeViewModel = bookTypesViewModels.FirstOrDefault(x => x.Id == id);

                if (bookTypeViewModel != null)
                {
                    bookTypeViewModel.IsSelected = true;
                }
            }

            var booksViewModels = booksRaw
                .Select(BookViewModel.ViewModel)
                .ToList();

            var viewModel = new IndexViewModel()
            {
                BookTypes = bookTypesViewModels,
                Books = booksViewModels
            };

            return this.View(viewModel);
        }

        public ActionResult Details()
        {
            return this.View();
        }
    }
}