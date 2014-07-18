namespace Slms.Desktop.SearchForms
{
    using System.Linq;

    using Slms.Common.Extentions;
    using Slms.Desktop.Common;
    using Slms.Desktop.ViewModels.Search;

    public partial class SearchForPublisherForm : BaseForm
    {
        public SearchForPublisherForm()
        {
            this.InitializeComponent();
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            var searchValue = this.PublisherNameTextBox.Text.Trim().ToLower();

            this.SearchResultDataGridView.DataSource = this.Data.Publishers
                .All()
                .Where(x => x.Name.ToLower().Contains(searchValue))
                .Select(PublisherSearchViewModel.ViewModel)
                .ToDataTable();
        }
    }
}
