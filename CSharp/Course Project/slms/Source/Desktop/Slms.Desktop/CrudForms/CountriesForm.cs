namespace Slms.Desktop.CrudForms
{
    using System.Linq;
    using System.Windows.Forms;

    using Slms.Common.Extentions;
    using Slms.Desktop.Common;
    using Slms.Desktop.ViewModels.Display;
    using Slms.Data.Models;

    public partial class CountriesForm : BaseForm
    {
        public CountriesForm()
        {
            this.InitializeComponent();
        }

        private void CountriesForm_Load(object sender, System.EventArgs e)
        {
            this.LoadGridData();
        }

        private void Create_Click(object sender, System.EventArgs e)
        {
            Country newCountry = new Country();
            newCountry.Name = "-";
            this.Data.Countries.Add(newCountry);
            this.Data.SaveChanges();
            
            this.LoadGridData();
            
            MessageBox.Show("Моля попълнете празния ред, след което натиснете Update.");
        }

        private void Update_Click(object sender, System.EventArgs e)
        {
            if (this.CountriesDataGrid.CurrentRow != null && this.CountriesDataGrid.CurrentRow.Index > -1)
            {
                int entityKey;

                if (this.TryGetSelectedEntityKey(out entityKey))
                {
                    var nameChangeValue = this.CountriesDataGrid.CurrentRow.Cells[1].Value.ToString();

                    if (!string.IsNullOrWhiteSpace(nameChangeValue))
                    {
                        var entity = this.Data.Countries.GetById(entityKey);
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
            if (this.CountriesDataGrid.CurrentRow != null && this.CountriesDataGrid.CurrentRow.Index > -1)
            {
                int entityKey;

                if (this.TryGetSelectedEntityKey(out entityKey))
                {
                    this.Data.Countries.Delete(entityKey);
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
            if (this.CountriesDataGrid.CurrentRow != null && this.CountriesDataGrid.CurrentRow.Index > -1)
            {
                var entityKeyRaw = this.CountriesDataGrid.CurrentRow.Cells[0].Value.ToString();

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

        private void LoadGridData()
        {
            this.CountriesDataGrid.DataSource = this.Data.Countries.All().Select(CountryGridViewModel.ViewModel).OrderByDescending(x => x.Id).ToDataTable();
        }

        private void Refresh_Click(object sender, System.EventArgs e)
        {
            this.LoadGridData();
        }
    }
}
