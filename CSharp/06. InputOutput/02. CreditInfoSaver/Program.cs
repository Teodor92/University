namespace _02.CreditInfoSaver
{
    using System.Collections.Generic;

    /// <summary>
    /// Пrogram that can be used for saving data about credits in two separate text files. 
    /// </summary>
    public class Program
    {
        internal static void Main(string[] args)
        {
            var credits = new List<Credit>();
            var borrowers = new List<Borrower>();

            for (int i = 0; i < 5; i++)
            {
                credits.Add(new Credit()
                {
                    CreditTerm = "Some term " + i,
                    CreditValue = i * 100,
                    AnnualRateOfExpenditures = i,
                    MonthlyInterest = i,
                    MonthlyTaxes = i
                });

                borrowers.Add(new Borrower()
                {
                    Name = "Sample name " + i,
                    Address = "Sample address" + i,
                    Incomes = i * 1000,
                    GuarantorIncome = i * 2000,
                    GuarantorName = "Sample Guarantaor Name " + i,
                    Occupation = "Sample occupation " + i
                });
            }

            SaveManager.SaveCollectionToFile(credits);
            SaveManager.SaveCollectionToFile(borrowers);
        }
    }
}
