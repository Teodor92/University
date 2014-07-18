namespace Slms.Desktop.MasterDetailForms
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using Slms.Common.Extentions;
    using Slms.Desktop.Common;
    using Slms.Desktop.ViewModels.Display;

    public partial class PublishersForm : BaseForm
    {
        public PublishersForm()
        {
            this.InitializeComponent();
        }

        private void PublishersForm_Load(object sender, EventArgs e)
        {
            this.PublisherMasterGridView.DataSource = this.Data.Publishers.All().Select(PublisherGridViewModel.ViewModel).ToList().ToDataTable();
            this.PublisherMasterGridView.SelectionChanged += OnDataGridRowSelect;
        }

        private void OnDataGridRowSelect(object sender, EventArgs e)
        {
            var publisherId = Convert.ToInt32(this.PublisherMasterGridView.CurrentRow.Cells[0].Value);

            this.BookDetailsGridView.DataSource =
                this.Data.Books.All()
                    .Include(x => x.Author)
                    .Include(x => x.Category)
                    .Include(x => x.Tags)
                    .Where(x => x.PublisherId == publisherId)
                    .ToList()
                    .AsQueryable()
                    .Select(BookGridViewModel.ViewModel)
                    .ToDataTable();
        }
    }
}
