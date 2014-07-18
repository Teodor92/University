namespace Slms.Desktop.SearchForms
{
    using System.Linq;
    using Slms.Common.Extentions;
    using Slms.Desktop.Common;
    using Slms.Desktop.ViewModels.Search;

    public partial class SearchForCountryForm : BaseForm
    {
        public SearchForCountryForm()
        {
            this.InitializeComponent();
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            var searchValue = this.CountryNameTextBox.Text.Trim().ToLower();

            this.SearchResultDataGridView.DataSource = this.Data.Countries
                .All()
                .Where(x => x.Name.ToLower().Contains(searchValue))
                .Select(CountrySearchViewModel.ViewModel)
                .ToDataTable();
        }
    }
}
