namespace CurrencyConverter
{
    using System;
    using System.Windows.Forms;

    public partial class CurrencyConverter : Form
    {
        public CurrencyConverter()
        {
            this.InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBoxSum.Text = string.Empty;
            this.comboBoxCurrency.SelectedIndex = -1;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            decimal sum = 0;
            var valid = decimal.TryParse(this.textBoxSum.Text, out sum);
            if (valid)
            {
                decimal bgnSum = 0m;
                decimal eurSum = 0m;
                decimal usdSum = 0m;
                decimal gbrSum = 0m;

                switch (this.comboBoxCurrency.SelectedIndex)
                {
                    case 0:
                        {
                            bgnSum = sum;
                            this.textBoxBGN.Text = bgnSum.ToString();
                            eurSum = sum / 1.92m;
                            this.textBoxEUR.Text = eurSum.ToString();
                            usdSum = sum / 1.50m;
                            this.textBoxUSD.Text = usdSum.ToString();
                            gbrSum = sum / 2.2m;
                            this.textBoxGBR.Text = gbrSum.ToString();
                        }

                        break;
                    case 1:
                        {
                            bgnSum = sum * 1.92m;
                            this.textBoxBGN.Text = bgnSum.ToString();
                            eurSum = sum;
                            this.textBoxEUR.Text = eurSum.ToString();
                            usdSum = sum * 1.38m;
                            this.textBoxUSD.Text = usdSum.ToString();
                            gbrSum = sum * 0.83m;
                            this.textBoxGBR.Text = gbrSum.ToString();
                        }

                        break;
                    case 2:
                        {
                            bgnSum = sum * 1.5m;
                            this.textBoxBGN.Text = bgnSum.ToString();
                            eurSum = sum * 0.73m;
                            this.textBoxEUR.Text = eurSum.ToString();
                            usdSum = sum;
                            this.textBoxUSD.Text = usdSum.ToString();
                            gbrSum = sum * 0.61m;
                            this.textBoxGBR.Text = gbrSum.ToString();
                        }

                        break;
                    case 3:
                        {
                            bgnSum = sum * 2.2m;
                            this.textBoxBGN.Text = bgnSum.ToString();
                            eurSum = sum * 1.2m;
                            this.textBoxEUR.Text = eurSum.ToString();
                            usdSum = sum * 1.65m;
                            this.textBoxUSD.Text = usdSum.ToString();
                            gbrSum = sum;
                            this.textBoxGBR.Text = gbrSum.ToString();
                        }

                        break;
                    default:
                        break;
                }
            }
        }
    }
}
