namespace Slms.Desktop.SearchForms
{
    using System.Linq;

    using Slms.Common.Extentions;
    using Slms.Desktop.Common;
    using Slms.Desktop.ViewModels.Search;

    public partial class SearchForAuthorComplexForm : BaseForm
    {
        public SearchForAuthorComplexForm()
        {
            this.InitializeComponent();
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            var authorName = this.AuthorNameTextBox.Text.Trim().ToLower();
            var countryName = this.CountryNameTextBox.Text.Trim().ToLower();

            var auhtorsResult = this.Data.Authors.All();

            if (!string.IsNullOrWhiteSpace(authorName))
            {
                auhtorsResult = auhtorsResult.Where(x => x.Name.ToLower().Contains(authorName));
            }

            if (!string.IsNullOrWhiteSpace(countryName))
            {
                auhtorsResult = auhtorsResult.Where(x => x.Country.Name.ToLower().Contains(countryName));
            }

            this.SearchResultDataGridView.DataSource = auhtorsResult.Select(АuthorSearchViewModel.ViewModel).ToDataTable();
        }
    }
}
