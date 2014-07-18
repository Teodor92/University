namespace Slms.Desktop.CrudForms
{
    using System.Linq;
    using System.Windows.Forms;

    using Slms.Common.Extentions;
    using Slms.Desktop.Common;
    using Slms.Desktop.ViewModels.Display;
    using Slms.Data.Models;

    public partial class TagsForm : BaseForm
    {
        public TagsForm()
        {
            this.InitializeComponent();
        }

        private void TagsForm_Load(object sender, System.EventArgs e)
        {
            this.TagsGridView.DataSource =
                this.Data.Tags.All()
                    .Select(TagGridViewModel.ViewModel)
                    .OrderByDescending(x => x.Id)
                    .ToList()
                    .ToDataTable();
        }

        private void Create_Click(object sender, System.EventArgs e)
        {
            Tag newTag = new Tag();
            newTag.Name = "-";
            this.Data.Tags.Add(newTag);
            this.Data.SaveChanges();

            this.LoadGridData();

            MessageBox.Show("Моля попълнете празния ред, след което натиснете Update.");
        }

        private void Update_Click(object sender, System.EventArgs e)
        {
            if (this.TagsGridView.CurrentRow != null && this.TagsGridView.CurrentRow.Index > -1)
            {
                int entityKey;

                if (this.TryGetSelectedEntityKey(out entityKey))
                {
                    var nameChangeValue = this.TagsGridView.CurrentRow.Cells[1].Value.ToString();

                    if (!string.IsNullOrWhiteSpace(nameChangeValue))
                    {
                        var entity = this.Data.Tags.GetById(entityKey);
                        entity.Name = nameChangeValue;
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
            if (this.TagsGridView.CurrentRow != null && this.TagsGridView.CurrentRow.Index > -1)
            {
                int entityKey;

                if (this.TryGetSelectedEntityKey(out entityKey))
                {
                    this.Data.Tags.Delete(entityKey);
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
            if (this.TagsGridView.CurrentRow != null && this.TagsGridView.CurrentRow.Index > -1)
            {
                var entityKeyRaw = this.TagsGridView.CurrentRow.Cells[0].Value.ToString();

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
            this.TagsGridView.DataSource = this.Data.Tags.All().OrderByDescending(x => x.Id).Select(TagGridViewModel.ViewModel).ToDataTable();
        }
    }
}
