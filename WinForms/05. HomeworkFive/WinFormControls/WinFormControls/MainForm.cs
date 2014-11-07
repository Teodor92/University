namespace WinFormControls
{
    using System;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;
    using WinFormControls.Models;

    public partial class MainForm : BaseForm
    {
        private const string DefaultErrorMessage = "Please check your input data and start again";

        public MainForm()
        {
            this.InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            var articleItems = this.Data.Nomenclatures
                .All()
                .Select(x => x.Name)
                .ToList();

            var currencies = this.Data.Currency
                .All()
                .Select(x => x.Name)
                .ToList();

            this.ArticleColumn.DataSource = articleItems;

            this.Currency.DataSource = currencies;
            this.Currency.SelectedIndex = -1;
        }

        private decimal GetMultipluer(string currencyCode)
        {
            switch (currencyCode)
            {
                case "USD":
                    return 1.5M;
                case "BGN":
                    return 1;
                default:
                    return 1;
            }
        }

        ////private void ValidateFileds()
        ////{
        ////    if (
        ////        string.IsNullOrWhiteSpace(this.unitPrice.Text))
        ////    {
        ////        throw new SimpleValidationException("Please fill the unit price");
        ////    }

        ////    if (string.IsNullOrWhiteSpace(this.quantity.Text))
        ////    {
        ////        throw new SimpleValidationException("Please fill the quantity");
        ////    }

        ////    decimal unitPriceNumber;
        ////    var unitPriceIsValid = decimal.TryParse(this.unitPrice.Text, out unitPriceNumber);

        ////    if (!unitPriceIsValid || unitPriceNumber < 0)
        ////    {
        ////        throw new SimpleValidationException("Please fill the unit price wiht a valid positive number");
        ////    }

        ////    decimal quantityNumber;
        ////    var quantityIsValid = decimal.TryParse(this.unitPrice.Text, out quantityNumber);

        ////    if (!quantityIsValid || quantityNumber < 0)
        ////    {
        ////        throw new SimpleValidationException("Please fill the quantity wiht a valid positive number");
        ////    }

        ////    if (this.Currency.SelectedIndex < 0)
        ////    {
        ////        throw new SimpleValidationException("Select a currency");
        ////    }

        ////    if ((this.Article.SelectedIndex < 0 && string.IsNullOrWhiteSpace(this.Article.Text)) || string.IsNullOrWhiteSpace(this.Article.Text))
        ////    {
        ////        throw new SimpleValidationException("Select a article");
        ////    }
        ////}

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to close this window?", 
                "Closing", 
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void newSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SalesGridView.Rows.Clear();
            this.CustomerTextBox.Clear();
            this.grandTotal.Clear();
            this.Currency.SelectedIndex = -1;
        }

        private void colorChangingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = this.colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.BackColor = this.colorDialog1.Color;
            }
        }

        private void articlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var articles = new Articles();
            articles.Show();
        }

        private void salesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var salesList = new SalesList();
            salesList.Show();
        }

        private void CustomerTextBox_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.CustomerTextBox.Text))
            {
                errorProvider1.SetError(this.CustomerTextBox, "Please fill the required field");
            }
        }

        private void CustomerTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            errorProvider1.SetError(this.CustomerTextBox, string.Empty);
        }

        private void SalesGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            decimal price = Convert.ToDecimal(this.SalesGridView.CurrentRow.Cells[1].Value);
            decimal qunatityValue = Convert.ToDecimal(this.SalesGridView.CurrentRow.Cells[2].Value);
            decimal totalValue = price * qunatityValue;
            decimal discoountPercentage = totalValue > 100 ? 0.9M : 1M;

            decimal totalValueDecudctedDiscount = totalValue * discoountPercentage;
            decimal discountValue = totalValue - totalValueDecudctedDiscount;

            this.SalesGridView.CurrentRow.Cells[3].Value = discountValue;
            this.SalesGridView.CurrentRow.Cells[4].Value = totalValueDecudctedDiscount;

            var gradDiscountOldValue = string.IsNullOrWhiteSpace(this.grandDiscount.Text) ? 0 : Convert.ToDecimal(this.grandDiscount.Text);

            this.grandDiscount.Text = (gradDiscountOldValue + discountValue).ToString(CultureInfo.InvariantCulture);

            var grandTotalOldValue = string.IsNullOrWhiteSpace(this.grandTotal.Text) ? 0 : Convert.ToDecimal(this.grandTotal.Text);
            this.grandTotal.Text =
                (grandTotalOldValue + totalValueDecudctedDiscount).ToString(CultureInfo.InvariantCulture);
        }
    }
}
