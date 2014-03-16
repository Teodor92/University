namespace _02.CreditInfoSaver
{
    public class Credit
    {
        public decimal MonthlyInterest { get; set; }

        public string CreditTerm { get; set; }

        public decimal CreditValue { get; set; }

        public decimal MonthlyTaxes { get; set; }

        public decimal AnnualRateOfExpenditures { get; set; }

        public override string ToString()
        {
            return string.Format(
                "Credit: {0} {1} {2} {3} {4}",
                this.MonthlyInterest,
                this.CreditTerm,
                this.CreditValue,
                this.MonthlyTaxes,
                this.AnnualRateOfExpenditures);
        }
    }
}
