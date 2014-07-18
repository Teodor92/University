namespace Slms.Desktop.CrudForms
{
    using System.Data.Entity;
    using System.Linq;
    using System.Windows.Forms;

    using Slms.Common.Extentions;
    using Slms.Desktop.Common;
    using Slms.Desktop.ViewModels.Display;
    using Slms.Data.Models;

    public partial class BooksForm : BaseForm
    {
        public BooksForm()
        {
            this.InitializeComponent();
        }

        private void BooksForm_Load(object sender, System.EventArgs e)
        {
            this.LoadGridData();
        }

        private void Create_Click(object sender, System.EventArgs e)
        {
            Book newBook = new Book();
            newBook.Title = "-";
            newBook.Author = this.Data.Authors.All().First();
            newBook.Category = this.Data.Categories.All().First();
            newBook.Publisher = this.Data.Publishers.All().First();

            this.Data.Books.Add(newBook);
            this.Data.SaveChanges();
            
            this.LoadGridData();
            
            MessageBox.Show("Моля попълнете данните, след което натиснете бутона Update");
        }

        private void Update_Click(object sender, System.EventArgs e)
        {
            if (this.BooksGridView.CurrentRow != null && this.BooksGridView.CurrentRow.Index > -1)
            {
                int entityKey;

                if (this.TryGetSelectedEntityKey(out entityKey))
                {
                    var nameChangeValue = this.BooksGridView.CurrentRow.Cells[1].Value.ToString();
                    var authorChangeValue = this.BooksGridView.CurrentRow.Cells[2].Value.ToString();
                    var tagChangeValue = this.BooksGridView.CurrentRow.Cells[3].Value.ToString();
                    var categoryChangeValue = this.BooksGridView.CurrentRow.Cells[4].Value.ToString();

                    if (!string.IsNullOrWhiteSpace(nameChangeValue))
                    {
                        var entity = this.Data.Books.GetById(entityKey);
                        
                        var author = this.Data.Authors.All().FirstOrDefault(x => x.Name.Equals(authorChangeValue, System.StringComparison.CurrentCultureIgnoreCase));
                        
                        if (author != null)
                        {
                            entity.Author = author;
                        }
                        else
                        {
                            MessageBox.Show("Възникна проблем - невалиден автор");
                        }

                        var tag = this.Data.Tags.All().FirstOrDefault(x => x.Name.Equals(tagChangeValue, System.StringComparison.CurrentCultureIgnoreCase));

                        if (tag != null)
                        {
                            entity.Tags.Clear();
                            entity.Tags.Add(tag);
                        }
                        else
                        {
                            MessageBox.Show("Възникна проблем - невалиден таг");
                        }

                        var category = this.Data.Categories.All().FirstOrDefault(x => x.Name.Equals(categoryChangeValue, System.StringComparison.CurrentCultureIgnoreCase));

                        if (category != null)
                        {
                            entity.Category = category;
                        }
                        else
                        {
                            MessageBox.Show("Възникна проблем - невалидна категория");
                        }


                        entity.Title = nameChangeValue;
                        this.Data.SaveChanges();
                    }

                    this.LoadGridData();
                }
                else
                {
                    MessageBox.Show("Възникна проблем, моля опитайте по-късно");
                }
            }
        }

        private void Delete_Click(object sender, System.EventArgs e)
        {
            if (this.BooksGridView.CurrentRow != null && this.BooksGridView.CurrentRow.Index > -1)
            {
                int entityKey;

                if (this.TryGetSelectedEntityKey(out entityKey))
                {
                    this.Data.Books.Delete(entityKey);
                    this.Data.SaveChanges();

                    this.LoadGridData();
                }
                else
                {
                    MessageBox.Show("Възникна проблем, моля опитайте по-късно");
                }
            }
        }

        private bool TryGetSelectedEntityKey(out int entityKey)
        {
            if (this.BooksGridView.CurrentRow != null && this.BooksGridView.CurrentRow.Index > -1)
            {
                var entityKeyRaw = this.BooksGridView.CurrentRow.Cells[0].Value.ToString();

                if (!int.TryParse(entityKeyRaw, out entityKey))
                {
                    MessageBox.Show("Редът има невалиден ключ");
                    return false;
                }
                else
                {
                    return true;
                }
            }

            MessageBox.Show("Моля изберте ред");

            entityKey = 0;
            return false;
        }

        private void Refresh_Click(object sender, System.EventArgs e)
        {
            this.LoadGridData();
        }

        private void LoadGridData()
        {
            this.BooksGridView.DataSource =
                this.Data.Books.All()
                    .Include(x => x.Author)
                    .Include(x => x.Category)
                    .Include(x => x.Tags)
                    .OrderByDescending(x => x.Id)
                    .ToList()
                    .AsQueryable()
                    .Select(BookGridViewModel.ViewModel)
                    .ToDataTable();
        }
    }
}
