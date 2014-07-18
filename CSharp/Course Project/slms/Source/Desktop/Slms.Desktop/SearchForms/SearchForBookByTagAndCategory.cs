namespace Slms.Desktop.SearchForms
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using Slms.Common.Extentions;
    using Slms.Desktop.Common;
    using Slms.Desktop.ViewModels.Search;

    public partial class SearchForBookByTagAndCategory : BaseForm
    {
        public SearchForBookByTagAndCategory()
        {
            this.InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var categoryName = this.CategoryNameTextBox.Text.Trim().ToLower();
            var tags = this.TagsTextBox.Text
                .Trim()
                .ToLower()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var booksResult = this.Data.Books.All()
                .Include(x => x.Tags)
                .Include(x => x.Category)
                .ToList()
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(categoryName))
            {
                booksResult = booksResult.Where(x => x.Category.Name.ToLower().Contains(categoryName));
            }

            if (tags.Any())
            {
                booksResult = booksResult.Where(x => x.Tags.Any(y => tags.Any(z => z == y.Name.ToLower())));
            }

            this.SearchResultDataGridView.DataSource = booksResult.Select(BookComplexSearchViewModel.ViewModel).ToDataTable();
        }
    }
}
