namespace Slms.Desktop.MasterDetailForms
{
    using System;
    using System.Linq;

    using Slms.Common.Extentions;
    using Slms.Desktop.Common;
    using Slms.Desktop.ViewModels.Display;

    public partial class AuthorsForm : BaseForm
    {
        public AuthorsForm()
        {
            this.InitializeComponent();
        }

        private void AuthorsForm_Load(object sender, EventArgs e)
        {
            this.AuthorMasterGridView.DataSource = this.Data.Authors.All().Select(AuthorGridViewModel.ViewModel).ToList().ToDataTable();
            this.AuthorMasterGridView.SelectionChanged += OnDataGridRowSelect;
        }

        private void OnDataGridRowSelect(object sender, EventArgs e)
        {
            var authorId = Convert.ToInt32(this.AuthorMasterGridView.CurrentRow.Cells[0].Value);
            
            this.DetailsBooksGridView.DataSource =
                this.Data.Books.All()
                    .Where(x => x.AuthorId == authorId)
                    .ToList()
                    .AsQueryable()
                    .Select(BookGridViewModel.ViewModel)
                    .ToDataTable();
        }
    }
}
