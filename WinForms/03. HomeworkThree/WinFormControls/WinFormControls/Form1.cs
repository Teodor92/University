namespace WinFormControls
{
    using System;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Forms;
    using WinFormControls.Models;

    public partial class BaseForm : Form
    {
        private const string DefaultErrorMessage = "Please check your input data and start again";


        public BaseForm()
        {
            this.InitializeComponent();
        }

        private void newSale_Click(object sender, EventArgs e)
        {
            this.Article.SelectedIndex = -1;
            this.unitPrice.Clear();
            this.quantity.Clear();
            this.discount.Clear();
            this.totalAmount.Clear();

            this.discountLabael.ForeColor = Color.Black;
            this.newSale.Enabled = false;
            this.total.Enabled = true;
        }

        private void total_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateFileds();

                var unitPricevalue = int.Parse(this.unitPrice.Text);
                var quantityValue = int.Parse(this.quantity.Text);
                decimal discountValue = quantityValue > 100 ? 0.1M : 0M;

                if (discountValue > 0)
                {
                    this.discountLabael.ForeColor = Color.Red;
                }
                else
                {
                    this.discountLabael.ForeColor = Color.Black;
                }

                var discountInMoney = (unitPricevalue * quantityValue * this.GetMultipluer(this.Currency.Text)) * discountValue;
                var totalValue = (unitPricevalue * quantityValue * this.GetMultipluer(this.Currency.Text)) - discountInMoney;

                this.discount.Text = discountInMoney.ToString(CultureInfo.InvariantCulture);
                this.totalAmount.Text = totalValue.ToString(CultureInfo.InvariantCulture);

                string[] historyInformation =
                {
                    Article.Text,
                    unitPrice.Text,
                    quantity.Text,
                    discount.Text,
                    totalAmount.Text
                };

                this.salesHistory.Items.Add(this.SaleDateFiled.Text).SubItems.AddRange(historyInformation);

                this.SaleDate.Enabled = false;
                this.newSale.Enabled = true;
                this.total.Enabled = false;
            }
            catch (SimpleValidationException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (Exception)
            {
                MessageBox.Show(DefaultErrorMessage);
            }
        }

        private void finishAllSales_Click(object sender, EventArgs e)
        {
            try
            {
                this.grandTotal.Text = this.totalAmount.Text;
                this.GradTotalEn.Text = (decimal.Parse(this.grandTotal.Text) * this.GetMultipluer(this.Currency.Text)).ToString(CultureInfo.InvariantCulture);
                this.grandDiscount.Text = this.discount.Text;
                this.numberOfSales.Text = this.quantity.Text;

                var grandDiscountValue = decimal.Parse(this.grandDiscount.Text);
                this.grandDiscountlLabel.ForeColor = grandDiscountValue > 0 ? Color.Red : Color.Black;

                this.Article.Enabled = false;
                this.unitPrice.Enabled = false;
                this.quantity.Enabled = false;
                this.SaleDate.Enabled = false;

                this.finishAllSales.Text = "New Operation";
                this.finishAllSales.Click += this.NewOperation_Click;
                this.newSale.Enabled = false;
                this.total.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show(DefaultErrorMessage);
            }
        }

        private void NewOperation_Click(object sender, EventArgs e)
        {
            try
            {
                this.Article.SelectedIndex = -1;
                this.unitPrice.Clear();
                this.quantity.Clear();
                this.discount.Clear();
                this.totalAmount.Clear();
                this.grandDiscount.Clear();
                this.grandTotal.Clear();
                this.numberOfSales.Clear();

                this.Article.Enabled = true;
                this.unitPrice.Enabled = true;
                this.quantity.Enabled = true;
                this.SaleDate.Enabled = true;

                this.grandDiscountlLabel.ForeColor = Color.Black;
                this.discountLabael.ForeColor = Color.Black;

                this.finishAllSales.Text = "Finish all Sales";
                this.finishAllSales.Click += this.finishAllSales_Click;
            }
            catch (Exception)
            {
                MessageBox.Show(DefaultErrorMessage);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            var initalComboBoxValues = new[] { "Article 1", "Article 2", "Article 3" };
            var currencies = new[] { "BGN", "USD", "GBN" };

            this.Article.DataSource = initalComboBoxValues;
            this.Article.SelectedIndex = -1;

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

        private void ValidateFileds()
        {
            if (
                string.IsNullOrWhiteSpace(this.unitPrice.Text))
            {
                throw new SimpleValidationException("Please fill the unit price");
            }

            if (string.IsNullOrWhiteSpace(this.quantity.Text))
            {
                throw new SimpleValidationException("Please fill the quantity");
            }

            decimal unitPriceNumber;
            var unitPriceIsValid = decimal.TryParse(this.unitPrice.Text, out unitPriceNumber);

            if (!unitPriceIsValid || unitPriceNumber < 0)
            {
                throw new SimpleValidationException("Please fill the unit price wiht a valid positive number");
            }

            decimal quantityNumber;
            var quantityIsValid = decimal.TryParse(this.unitPrice.Text, out quantityNumber);

            if (!quantityIsValid || quantityNumber < 0)
            {
                throw new SimpleValidationException("Please fill the quantity wiht a valid positive number");
            }

            if (this.Currency.SelectedIndex < 0)
            {
                throw new SimpleValidationException("Select a currency");
            }

            if ((this.Article.SelectedIndex < 0 && string.IsNullOrWhiteSpace(this.Article.Text)) || string.IsNullOrWhiteSpace(this.Article.Text))
            {
                throw new SimpleValidationException("Select a article");
            }
        }
    }
}
