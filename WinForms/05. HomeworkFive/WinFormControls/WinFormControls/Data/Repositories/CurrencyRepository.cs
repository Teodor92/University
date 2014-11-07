namespace WinFormControls.Data.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    using WinFormControls.Data.Contracts;
    using WinFormControls.Models;

    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly IEnumerable<Currency> sampleCurrencies;

        public CurrencyRepository(IEnumerable<Currency> items = null)
        {
            this.sampleCurrencies = items;
        }

        public IEnumerable<Currency> All()
        {
            return this.sampleCurrencies;
        }

        public Currency Find(int id)
        {
            return this.sampleCurrencies.FirstOrDefault(x => x.Id == id);
        }
    }
}
