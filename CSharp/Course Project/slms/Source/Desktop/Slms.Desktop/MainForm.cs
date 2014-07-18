using Slms.Desktop.CrudForms;
using Slms.Desktop.MasterDetailForms;

namespace Slms.Desktop
{
    using System;
    using System.Windows.Forms;

    using Slms.Desktop.Common;
    using Slms.Desktop.SearchForms;

    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            this.InitializeComponent();
        }

        private void AuthorsMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowForm<AuthorsForm>();
        }

        private void CategoriesMenuIItem_Click(object sender, EventArgs e)
        {
            this.ShowForm<CategoriesForm>();
        }

        private void TagsMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowForm<TagsForm>();
        }

        private void PublishersMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowForm<PublishersForm>();
        }

        private void BooksMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowForm<BooksForm>();
        }

        private void CountriesMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowForm<CountriesForm>();
        }

        private void AuthorSearchMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowForm<SearchForAuthorForm>();
        }

        private void търсенеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ComplexBooksSearchMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowForm<SearchForBookComplexForm>();
        }

        private void SearchForBooksByTagAndCategoryMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowForm<SearchForBookByTagAndCategory>();
        }

        private void CountrySearchMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowForm<SearchForCountryForm>();
        }

        private void PublisherSearchMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowForm<SearchForPublisherForm>();
        }

        private void AuthorSearchComplexMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowForm<SearchForAuthorComplexForm>();
        }

        private void ExitAppMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowForm<T>() where T : Form, new()
        {
            var form = new T()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };

            form.Show();
        }
    }
}
