namespace Slms.Desktop.SearchForms
{
    using System;
    using System.Linq;
    using Slms.Common.Extentions;
    using Slms.Desktop.Common;
    using Slms.Desktop.ViewModels.Search;

    public partial class SearchForAuthorForm : BaseForm
    {
        public SearchForAuthorForm()
        {
            this.InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var searchValue = this.SearchTextBox.Text.Trim().ToLower();

            this.SearchResultGridView.DataSource = this.Data.Authors
                .All()
                .Where(x => x.Name.ToLower().Contains(searchValue))
                .Select(АuthorSearchViewModel.ViewModel)
                .ToDataTable();
        }
    }
}
