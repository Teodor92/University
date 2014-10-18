namespace WinFormControls
{
    using System;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Forms;

    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            this.InitializeComponent();
        }

        private void newSale_Click(object sender, EventArgs e)
        {
            this.article.Clear();
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
                if (string.IsNullOrWhiteSpace(this.quantity.Text) ||
                    string.IsNullOrWhiteSpace(this.unitPrice.Text))
                {
                    MessageBox.Show("Fill all fields");
                }
                else
                {
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

                    var discountInMoney = (unitPricevalue * quantityValue) * discountValue;
                    var totalValue = (unitPricevalue * quantityValue) - discountInMoney;

                    this.discount.Text = discountInMoney.ToString(CultureInfo.InvariantCulture);
                    this.totalAmount.Text = totalValue.ToString(CultureInfo.InvariantCulture);

                    this.newSale.Enabled = true;
                    this.total.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your input data and start again");
            }
        }

        private void finishAllSales_Click(object sender, EventArgs e)
        {
            try
            {
                this.grandTotal.Text = this.totalAmount.Text;
                this.grandDiscount.Text = this.discount.Text;
                this.numberOfSales.Text = this.quantity.Text;

                var grandDiscountValue = decimal.Parse(this.grandDiscount.Text);

                if (grandDiscountValue > 0)
                {
                    this.grandDiscountlLabel.ForeColor = Color.Red;
                }
                else
                {
                    this.grandDiscountlLabel.ForeColor = Color.Black;
                }

                this.article.Enabled = false;
                this.unitPrice.Enabled = false;
                this.quantity.Enabled = false;

                this.finishAllSales.Text = "New Operation";
                this.finishAllSales.Click += this.NewOperation_Click;
                this.newSale.Enabled = false;
                this.total.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your input data and start again");
            }
        }

        private void NewOperation_Click(object sender, EventArgs e)
        {
            try
            {
                this.article.Clear();
                this.unitPrice.Clear();
                this.quantity.Clear();
                this.discount.Clear();
                this.totalAmount.Clear();
                this.grandDiscount.Clear();
                this.grandTotal.Clear();
                this.numberOfSales.Clear();

                this.article.Enabled = true;
                this.unitPrice.Enabled = true;
                this.quantity.Enabled = true;

                this.grandDiscountlLabel.ForeColor = Color.Black;
                this.discountLabael.ForeColor = Color.Black;

                this.finishAllSales.Text = "Finish all Sales";
                this.finishAllSales.Click += this.finishAllSales_Click;
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your input data and start again");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
