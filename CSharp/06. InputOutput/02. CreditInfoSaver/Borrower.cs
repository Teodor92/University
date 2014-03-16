namespace _02.CreditInfoSaver
{
    public class Borrower
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Occupation { get; set; }

        public decimal Incomes { get; set; }

        public string GuarantorName { get; set; }

        public decimal GuarantorIncome { get; set; }

        public override string ToString()
        {
            return string.Format(
                "Borrower: {0} {1} {2} {3} {4} {5}",
                this.Name,
                this.Address,
                this.Occupation,
                this.Incomes,
                this.GuarantorName,
                this.GuarantorIncome);
        }
    }
}
