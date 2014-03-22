namespace CentralLoanRegister
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    public partial class Credit : Form
    {
        public Credit()
        {
            this.InitializeComponent();
        }

        private void buttonSaveBorrowerInformation_Click(object sender, EventArgs e)
        {
            var writer = new StreamWriter("../../borrower-info.txt");
            using (writer)
            {
                writer.WriteLine("EGN: {0}", this.textBoxEGN.Text);
                writer.WriteLine("First Name: {0}", this.textBoxFirstName.Text);
                writer.WriteLine("Last Name: {0}", this.textBoxLastName.Text);
                writer.WriteLine("Home Address: {0}", this.textBoxHomeAddress.Text);
                writer.WriteLine("Work Address: {0}", this.textBoxWorkAddress.Text);
                writer.WriteLine("Monthly Income: {0}", this.textBoxMonthlyIncome.Text);
                writer.WriteLine("Guarantor Name: {0}", this.textBoxGuarantorName.Text);
            }
        }

        private void buttonSaveLoanInformation_Click(object sender, EventArgs e)
        {
            var writer = new StreamWriter("../../loan-info.txt");
            using (writer)
            {
                writer.WriteLine("Monthly Interest: {0}", this.textBoxMonthlyInterest.Text);
                writer.WriteLine("Deadline: {0}", this.textBoxDeadline.Text);
                writer.WriteLine("Loan Cost: {0}", this.textBoxLoanCost.Text);
                writer.WriteLine("Monthly Taxes: {0}", this.textBoxMonthlyTaxes.Text);
                writer.WriteLine("Overdue Interest: {0}", this.textBoxOverdueInterest.Text);
                writer.WriteLine("Yearly Cost Interest: {0}", this.textBoxYearlyCostInterest.Text);
            }
        }
    }
}
