namespace WinFormControls.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using WinFormControls.Data.Contracts;
    using WinFormControls.Data.Contracts.Base;
    using WinFormControls.Data.Repositories;
    using WinFormControls.Models;
    using WinFormControls.Provider;

    public class DataManager : IDataManager
    {
        private static readonly object SyncRoot = new object();
        private static volatile DataManager instance;

        private readonly ICurrencyRepository currencyRepository;
        private readonly INomenclatureRepository nomenclatureRepository;

        public DataManager()
        {
            var currencies = new HashSet<Currency>
            {
                new Currency
                {
                    Id = 1,
                    Name = "BGN",
                    BgExacaneRate = 1
                },

                new Currency
                {
                    Id = 2,
                    Name = "USD",
                    BgExacaneRate = 1.53M
                },
            };

            var nomenclatures = new HashSet<Nomenclature>
            {
                new Nomenclature
                {
                    Id = 1,
                    Name = "Sample Articels",
                    Price = 100M,
                    Currency = currencies.FirstOrDefault(x => x.Name == "BGN"),
                },

                new Nomenclature
                {
                    Id = 1,
                    Name = "Sample Articels 12",
                    Price = 200M,
                    Currency = currencies.FirstOrDefault(x => x.Name == "BGN"),
                },

                new Nomenclature
                {
                    Id = 1,
                    Name = "Sample Articels 23",
                    Price = 300M,
                    Currency = currencies.FirstOrDefault(x => x.Name == "BGN"),
                },
            };

            this.nomenclatureRepository = new NomenclatureRepository(nomenclatures);
            this.currencyRepository = new CurrencyRepository(currencies);
        }

        public static DataManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (SyncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new DataManager();
                        }
                    }
                }

                return instance;
            }
        }

        public ICurrencyRepository Currency
        {
            get { return this.currencyRepository; }
        }

        public INomenclatureRepository Nomenclatures
        {
            get { return this.nomenclatureRepository; }
        }
    }
}
