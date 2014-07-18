using System.Data.Entity;

namespace Slms.Desktop.SearchForms
{
    using System;
    using System.Linq;
    using Slms.Common.Extentions;
    using Slms.Desktop.Common;
    using Slms.Desktop.ViewModels.Search;

    public partial class SearchForBookComplexForm : BaseForm
    {
        public SearchForBookComplexForm()
        {
            this.InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var authorName = this.AuthorNameTextBox.Text.Trim().ToLower();
            var bookName = this.BookNameTextBox.Text.Trim().ToLower();

            var booksResult = this.Data.Books.All()
                .Include(x => x.Tags)
                .Include(x => x.Category)
                .ToList()
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(authorName))
            {
                booksResult = booksResult.Where(x => x.Author.Name.ToLower().Contains(authorName));
            }

            if (!string.IsNullOrWhiteSpace(bookName))
            {
                booksResult = booksResult.Where(x => x.Title.Contains(bookName));
            }

            this.SearchResultDataGrid.DataSource = booksResult.Select(BookComplexSearchViewModel.ViewModel).ToDataTable();
        }
    }
}
