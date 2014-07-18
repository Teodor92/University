namespace Slms.Desktop.MasterDetailForms
{
    using System;
    using System.Linq;

    using Slms.Common.Extentions;
    using Slms.Desktop.Common;
    using Slms.Desktop.ViewModels.Display;

    public partial class CategoriesForm : BaseForm
    {
        public CategoriesForm()
        {
            this.InitializeComponent();
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            this.MasterCategoryGridView.DataSource = this.Data.Categories.All().Select(CategoryGridViewModel.ViewModel).ToList().ToDataTable();
            this.MasterCategoryGridView.SelectionChanged += OnDataGridRowSelect;
        }

        private void OnDataGridRowSelect(object sender, EventArgs e)
        {
            var categoryId = Convert.ToInt32(this.MasterCategoryGridView.CurrentRow.Cells[0].Value);

            this.DetailsBooksGridView.DataSource =
                this.Data.Books.All()
                    .Where(x => x.CategoryId == categoryId)
                    .ToList()
                    .AsQueryable()
                    .Select(BookGridViewModel.ViewModel)
                    .ToDataTable();
        }
    }
}
